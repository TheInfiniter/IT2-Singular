using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Singular
{
    public partial class Window : MaterialForm
    {
        Stuff model;
        double[] Signal, Imp, Convolution, Restored_Orig, Restored_Compare;
        bool restore = true;
        double temp_epsilon, epsilon;
        int noise_param = 0;

        public Window()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800,
                Primary.Cyan900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            ResetFlatButton_Click(sender, e);
        }

        private void ModelInitiate()
        {
            model = new Stuff();
            model.SetSize(arrayText);
            model.SetAmp(amp1Text, amp2Text, amp3Text);
            model.SetCenter(center1Text, center2Text, center3Text);
            model.SetDisp(disp1Text, disp2Text, disp3Text);
            model.SetAlpha(alphaText);
            model.SetEdge(percentText);
            model.SetNormal(normalParamText);
        }

        private void DrawFlatButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(alphaText.Text) < 0.5 || Convert.ToDouble(alphaText.Text) > 4)
            {
                MessageBox.Show("Введён неподходящий параметр импульсной характеристики. Введите другой.", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ResetFlatButton_Click(sender, e);

                model.MatrixAction();

                Restored_Orig = new double[model.GetSize()];
                Restored_Compare = new double[model.GetSize()];
                Restored_Compare = model.GetRestored();

                SourceChart.Series[1].Points.Clear();
                for (int i = 0; i < model.GetSize(); i++)
                {
                    Restored_Orig[i] = Restored_Compare[i];
                    SourceChart.Series[1].Points.AddXY(i, Restored_Orig[i]);                    
                }
            }
        }

        private void ResetFlatButton_Click(object sender, EventArgs e)
        {
            ModelInitiate();
            model.CreateSignal();

            Signal = new double[model.GetSize()];
            Signal = model.GetSignal();

            Imp = new double[model.GetSize()];
            Imp = model.GetImpulse();

            Convolution = new double[model.GetSize()];
            Convolution = model.GetConvol();

            SourceChart.Series[0].Points.Clear();
            SourceChart.Series[1].Points.Clear();
            ImpulseChart.Series[0].Points.Clear();
            ConvolChart.Series[0].Points.Clear();
            ReseachChart.Series[0].Points.Clear();

            for (int i = 1; i < model.GetSize(); i++)
            {
                SourceChart.Series[0].Points.AddXY(i, Signal[i]);
                ImpulseChart.Series[0].Points.AddXY(i, Imp[i]);
                ConvolChart.Series[0].Points.AddXY(i, Convolution[i]);
            }
        }

        private void StartStopAnimateFlatButton_Click(object sender, EventArgs e)
        {
            model.current_noise = 0;
            ReseachChart.Series[0].Points.Clear();
            Animate_Timer.Enabled = true;
            StartStopAnimateFlatButton.Enabled = false;
        }

        private void Animate_Timer_Tick(object sender, EventArgs e)
        {
            noise_param += 5;
            for (int j = 0; j < model.GetNormal(); j++)
            {
                temp_epsilon = 0;
                model.Research(noise_param);
                Restored_Compare = model.GetRestored();

                for (int i = 0; i < model.GetSize(); i++) //считаем отклонение
                {
                    temp_epsilon += (Restored_Compare[i] - Restored_Orig[i]) * (Restored_Compare[i] - Restored_Orig[i]);
                }
                //temp_epsilon /= model.GetSize();
            }
            temp_epsilon /= model.GetNormal();
            epsilon += temp_epsilon;

            ReseachChart.Series[0].Points.AddXY(noise_param, epsilon);
            InfoBar.Items[0].Text = "отклонение: " + epsilon.ToString();

            if (noise_param == 95)
            {
                Animate_Timer.Enabled = false;
                StartStopAnimateFlatButton.Enabled = true;
                noise_param = 0;
                epsilon = 0;
            }
        }
    }
}
