//m_m - кол-во строк автокоррел€ционной матрицы
//n_n - кол-во столбцов автокоррел€ционной матрицы
//a - автокоррел€ционна€ матрица
//u - лева€ сингул€рна€ матрица
//v - права€ сингул€рна€ матрица
//sigma - матрица с сингул€рными числами

int CSistDoc::svd_hestenes(int m_m, int n_n, float * a, float * u, float * v, float * sigma)
{
float thr=0.000001f;
int n,m,i,j,l,k,lort,iter, in,ll,kk;
float alfa,betta,hamma,eta,t,cos0,sin0,buf,s,r ;
  n = n_n;
  m = m_m;
	for(i=0;i<n;i++)
        { in=i*n;
		for(j=0;j<n;j++)
			if(i==j) v[in+j]=1.;
			else v[in+j]=0.;
         }
	for(i=0;i<m;i++)
        {       in=i*n;
		for(j=0;j<n;j++)
		{
			u[in+j]=a[in+j];
                 }
          }

	iter=0;
	while(1)
		{
		 lort=0;
		iter++;
		for(l=0;l<n-1;l++)
			for(k=l+1;k<n;k++)
				{
		      alfa=0.; betta=0.; hamma=0.;
				for(i=0;i<m;i++)
					{
                                        in=i*n;
                                        ll=in+l;
                                        kk=in+k;
					alfa += u[ll]*u[ll];
					betta+= u[kk]*u[kk];
					hamma+= u[ll]*u[kk];
					}

				if( sqrt(alfa*betta) < 1.e-10 )	continue;
				if(fabs(hamma)/sqrt(alfa*betta)<thr)
							continue;

				lort=1;
				 eta=(betta-alfa)/(2.f*hamma);
				 t=(eta/fabs(eta))/
						(fabs(eta)+(float)sqrt(1.f+eta*eta));
				 cos0=1.f/(float)sqrt(1.f+t*t);
				 sin0=t*cos0;

				for(i=0;i<m;i++)
					{
                                        in=i*n;
					buf=u[in+l]*cos0-u[in+k]*sin0;
					u[in+k]=u[in+l]*sin0+u[in+k]*cos0;
					u[in+l]=buf;

					if(i>=n) continue;
					buf=v[in+l]*cos0-v[in+k]*sin0;
					v[in+k]=v[in+l]*sin0+v[in+k]*cos0;
					v[in+l]=buf;
					}
				}

		if(!lort) break;
		}

	for(i=0;i<n;i++)
		{
	        s=0.;
		for(j=0;j<m;j++)	s+=u[j*n+i]*u[j*n+i];
		s=(float)sqrt(s);
		sigma[i]=s;
			if( s < 1.e-10 )	continue;
		for(j=0;j<m;j++)	u[j*n+i]=u[j*n+i]/s;
		}
	for(i=0;i<n-1;i++)
		for(j=i;j<n;j++)
			if(sigma[i]<sigma[j])
				{
					r=sigma[i]; sigma[i]=sigma[j]; sigma[j]=r;
					for(k=0;k<m;k++)
					{ r= u[i+k*n]; u[i+k*n]=u[j+k*n]; u[j+k*n]=r;}
					for(k=0;k<n;k++)
					{ r= v[i+k*n]; v[i+k*n]=v[j+k*n]; v[j+k*n]=r;}
				}

	return iter;
}
