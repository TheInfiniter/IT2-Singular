using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singular
{
    class Stuff
    {
        int arraysize, normal_par;
        public int current_noise = 0;
        double alpha, percent, epsilon;
        
        double[] ArrayAmplitude, ArrayCenter, ArrayDisp;
        double[] Y, Impulse, Convol, Restored_Cmp, Restored_Orig, ImpArray;
        double[,] PseudoMatrix, U_Matrix, V_Matrix, Sigma_Matrix;
        double[] U, V, Sigma;
        static Random rand = new Random();

        public Stuff()
        {
            ArrayAmplitude = new double[3];
            ArrayCenter = new double[3];
            ArrayDisp = new double[3];
        }

        //установка амплитуд
        internal void SetAmp(TextBox A1, TextBox A2, TextBox A3)
        {
            ArrayAmplitude[0] = Convert.ToDouble(A1.Text);
            ArrayAmplitude[1] = Convert.ToDouble(A2.Text);
            ArrayAmplitude[2] = Convert.ToDouble(A3.Text);
        }

        //установка центров
        internal void SetCenter(TextBox Center1, TextBox Center2, TextBox Center3)
        {
            ArrayCenter[0] = Convert.ToDouble(Center1.Text);
            ArrayCenter[1] = Convert.ToDouble(Center2.Text);
            ArrayCenter[2] = Convert.ToDouble(Center3.Text);
        }

        //установка дисперсий
        internal void SetDisp(TextBox Disp1, TextBox Disp2, TextBox Disp3)
        {
            ArrayDisp[0] = Convert.ToDouble(Disp1.Text);
            ArrayDisp[1] = Convert.ToDouble(Disp2.Text);
            ArrayDisp[2] = Convert.ToDouble(Disp3.Text);
        }

        //установка размера массивов
        internal void SetSize(TextBox size)
        {
            arraysize = Convert.ToInt32(size.Text);

            Y = new double[arraysize];
            Impulse = new double[arraysize];
            Convol = new double[arraysize];
            Restored_Cmp = new double[arraysize];
            Restored_Orig = new double[arraysize];            

            U_Matrix = new double[arraysize, arraysize];
            V_Matrix = new double[arraysize, arraysize];
            Sigma_Matrix = new double[arraysize, arraysize];
            PseudoMatrix = new double[arraysize, arraysize];

            U = new double[arraysize * arraysize];
            V = new double[arraysize * arraysize];
            Sigma = new double[arraysize];

            ImpArray = new double[arraysize * arraysize];
        }

        //установка параметра нормализации
        internal void SetNormal(TextBox normalParam)
        {
            normal_par = Convert.ToInt32(normalParam.Text);
        }

        //установка параметра для импульсной характеристики
        internal void SetAlpha(TextBox param)
        {
            alpha = Convert.ToDouble(param.Text);
        }

        //установка порогового значения
        internal void SetEdge(TextBox edge_value)
        {
            percent = Convert.ToDouble(edge_value.Text) / 100;
        }


        //======= ОСНОВНЫЕ МЕТОДЫ =======
        //создание сигнала, импульсной характеристики, и свёртки
        internal void CreateSignal()
        {
            current_noise = 0;
            for (int i = 0; i < arraysize; i++)
            {
                Y[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    Y[i] += ArrayAmplitude[j] * Math.Exp(-(i - ArrayCenter[j]) * (i - ArrayCenter[j])
                        / (ArrayDisp[j] * ArrayDisp[j]));
                }
            }            

            //создаем импульсную характеристику
            //Impulse[0] = 0.05;
            for (int i = 1; i < arraysize; i++)
            {                
                if (i < arraysize / 2)
                    Impulse[i] = Math.Abs(Math.Sin(alpha * i) / (alpha * i));
                else
                    Impulse[i] = Math.Abs(Math.Sin(alpha * (arraysize - i)) / (alpha * (arraysize - i)));
            }
            Impulse[0] = Impulse[1] + Impulse[1] * 0.1;

            //проводим свертку
            for (int i = 0; i < arraysize; i++)
            {
                Convol[i] = 0;
                for (int j = 0; j < arraysize; j++)
                {
                    if ((i - j) < 0)
                        Convol[i] += Y[j] * Impulse[arraysize + (i - j)];
                    else
                        Convol[i] += Y[j] * Impulse[i - j];
                }
            }

            //создаём матрицу импульсной характеристики
            CreateArray();
        }        

        //процесс получения псевдообратной матрицы и её умножение на свёртку
        internal void MatrixAction()
        {
            Svd_hestenes();

            U_Matrix = MatrixRebuild(U);
            U_Matrix = MatrixTrans(U_Matrix);

            V_Matrix = MatrixRebuild(V);

            Sigma_Matrix = MatrixInverse(Sigma, percent);

            PseudoMatrix = MatrixOnMatrix(V_Matrix, Sigma_Matrix);
            PseudoMatrix = MatrixOnMatrix(PseudoMatrix, U_Matrix);

            Restored_Cmp = MatrixOnVector(PseudoMatrix, Convol);
        }


        //======= ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ =======
        //добавление шума к свёртке
        internal void AddNoise(double[] array, int size, int Percent)
        {
            double f;

            double[] n = new double[size];
            for (int t = 0; t < size; t++)
            {
                f = 0;
                for (int j = 0; j < 20; j++)
                {
                    f += Convert.ToDouble(rand.Next(-2000, 2001)) / 2000;
                }
                n[t] = f / 20;
            }
            double shumy = 0;
            for (int t = 0; t < size; t++)
            {
                shumy += array[t] * array[t];
            }

            double shumn = 0;
            for (int t = 0; t < size; t++)
            {
                shumn += n[t] * n[t];
            }

            double noise_percent = Percent;
            noise_percent /= 100;
            //подсчёт коэфициента альфа
            double alfa = Math.Sqrt(noise_percent * shumy / shumn);

            for (int t = 0; t < size; t++)
            {
                array[t] = array[t] + (double)(alfa * n[t]);
            }
        }

        //исследование зависимости восстановления от уровня шума
        internal void Research(int noise)
        {
            //current_noise += 5;

            CreateSignal(); //заново создаем сигнал
            AddNoise(Convol, arraysize, noise); //накладываем на текущую свёртку шум
            MatrixAction(); //заново составляем псевдообратную матрицу
            //Restored_Cmp = MatrixOnVector(PseudoMatrix, Convol); //восстанавливаем сигнал с шумом
        }

        //запись данных импульсной характеристики в массив        
        internal void CreateArray()
        {
            double temp;
            int count = 0, step = 0;

            while(count < (arraysize * arraysize))
            {
                for (int i = 0; i < arraysize; i++)
                {
                    ImpArray[step] = Impulse[i];
                    step++;
                }
                temp = Impulse[arraysize - 1];

                for (int j = arraysize - 1; j > 0; j--)
                {
                    Impulse[j] = Impulse[j - 1];
                }
                Impulse[0] = temp;
                count += arraysize;
            }
        }        

        //сингулярное преобразование
        internal int Svd_hestenes()
        {
            float thr = 0.000001f;
            int n, m, i, j, l, k, lort, iter, ink, ll, kk;
            double alfa, betta, hamma, eta, t, cos0, sin0, buf, s, r;
            n = arraysize;
            m = arraysize;
            for (i = 0; i < n; i++)
            {
                ink = i * n;
                for (j = 0; j < n; j++)
                    if (i == j) V[ink + j] = 1.0;
                    else V[ink + j] = 0.0;
            }
            for (i = 0; i < m; i++)
            {
                ink = i * n;
                for (j = 0; j < n; j++)
                {
                    U[ink + j] = ImpArray[ink + j];
                }
            }

            iter = 0;
            while (true)
            {
                lort = 0;
                iter++;
                for (l = 0; l < n - 1; l++)
                {
                    for (k = l + 1; k < n; k++)
                    {
                        alfa = 0.0; betta = 0.0; hamma = 0.0;
                        for (i = 0; i < m; i++)
                        {
                            ink = i * n;
                            ll = ink + l;
                            kk = ink + k;
                            alfa += U[ll] * U[ll];
                            betta += U[kk] * U[kk];
                            hamma += U[ll] * U[kk];
                        }

                     /*   if (betta == alfa)
                        {                            
                            flagsvd = true;
                        };

                        if (flagsvd == true) break;*/

                        if (Math.Sqrt(alfa * betta) < 1e-10) continue;
                        if (Math.Abs(hamma) / Math.Sqrt(alfa * betta) < thr)
                            continue;

                        lort = 1;
                        eta = (betta - alfa) / (2.0f * hamma);
                        t = (eta / Math.Abs(eta)) / (Math.Abs(eta) + (float)Math.Sqrt(1.0f + eta * eta));
                        cos0 = 1.0f / (float)Math.Sqrt(1.0f + t * t);
                        sin0 = t * cos0;

                        for (i = 0; i < m; i++)
                        {
                            ink = i * n;
                            buf = U[ink + l] * cos0 - U[ink + k] * sin0;
                            U[ink + k] = U[ink + l] * sin0 + U[ink + k] * cos0;
                            U[ink + l] = buf;

                            if (i >= n) continue;
                            buf = V[ink + l] * cos0 - V[ink + k] * sin0;
                            V[ink + k] = V[ink + l] * sin0 + V[ink + k] * cos0;
                            V[ink + l] = buf;
                        }
                    }
                }
                if (lort == 0) break;
                //if (!lort) break;
            }

            for (i = 0; i < n; i++)
            {
                s = 0.0;
                for (j = 0; j < m; j++) s += U[j * n + i] * U[j * n + i];
                s = (float)Math.Sqrt(s);
                Sigma[i] = s;
                if (s < 1e-10) continue;
                for (j = 0; j < m; j++) U[j * n + i] = U[j * n + i] / s;
            }
            for (i = 0; i < n - 1; i++)
                for (j = i; j < n; j++)
                    if (Sigma[i] < Sigma[j])
                    {
                        r = Sigma[i]; Sigma[i] = Sigma[j]; Sigma[j] = r;
                        for (k = 0; k < m; k++)
                        { r = U[i + k * n]; U[i + k * n] = U[j + k * n]; U[j + k * n] = r; }
                        for (k = 0; k < n; k++)
                        { r = V[i + k * n]; V[i + k * n] = V[j + k * n]; V[j + k * n] = r; }
                    }

            return iter;
        }

        //обращение центральной матрицы, и восстановление её до нужного вида
        internal double[,] MatrixInverse(double[] sigma, double percent)
        {
            //после сингулярного разложения мы получили МАССИВ сингулярных чисел, а не матрицу
            //это требуется исправить, предварительно обратив сингулярные числа
            double temp_value = sigma[0] * percent;

            for (int i = 0; i < sigma.GetLength(0); i++)
            {
                if (sigma[i] >= temp_value)
                    sigma[i] = 1 / sigma[i];
                else
                    sigma[i] = 0;
            }

            double[,] result = new double[sigma.GetLength(0), sigma.GetLength(0)];

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    if (i == j)
                        result[i, j] = sigma[i];
                    else
                        result[i, j] = 0;
                }
            }

            return result;
        }

        //восстановление боковой матрицы до нужного вида
        internal double[,] MatrixRebuild(double[] array)
        {
            double[,] result = new double[arraysize, arraysize];
            int temp = 0;

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    result[i, j] = array[j + temp];
                }
                temp += arraysize;
            }

            return result;
        }

        //транспонирование матрицы
        internal double[,] MatrixTrans(double[,] matrix)
        {
            //double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            double temp;

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            return matrix;
        }

        //умножение матрицы на матрицу
        internal double[,] MatrixOnMatrix(double[,] a, double[,] b)
        {
            double[,] result = new double[arraysize, arraysize];
            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    for (int k = 0; k < arraysize; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        //умножение матрицы на вектор
        internal double[] MatrixOnVector(double[,] matrix, double[] vector)
        {
            double[] result = new double[arraysize];

            for (int i = 0; i < arraysize; i++)
            {
                for (int j = 0; j < arraysize; j++)
                {
                    result[i] += matrix[i, j] * vector[j];
                }
            }
            return result;
        }



        //======= ФУНКЦИИ ВОЗВРАТА ДАННЫХ ДЛЯ ОТРИСОВКИ =======
        internal double[] GetSignal()
        {
            return Y;
        }

        internal double[] GetImpulse()
        {
            return Impulse;
        }

        internal double[] GetConvol()
        {
            return Convol;
        }

        internal int GetSize()
        {
            return arraysize;
        }

        internal int GetCurrentNoise()
        {
            return current_noise;
        }

        internal int GetNormal()
        {
            return normal_par;
        }

        internal double[] GetRestored()
        {
            return Restored_Cmp;
        }

        internal double GetEpsilon()
        {
            return epsilon;
        }
    }
}
