using System;
using System.Windows.Forms;

namespace Maths_For_Sound_Engeeniering
{
    public partial class Form1 : Form
    {
        int t;
        double v;
        public Form1()
        {
            InitializeComponent();
           
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void btnVelocidad_Click(object sender, EventArgs e)
        {
            t = Convert.ToInt32(txtTemp.Text);           
            v = 331.5 + (t * 0.6);
            lstVel.Items.Add(v);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCLEARVELOCIDAD_Click(object sender, EventArgs e)
        {
            lstVel.Items.Clear();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int f, ops, opi;
            double l, p;
            f = Convert.ToInt32(txtFreq.Text);
            if (f <= 20000 && f >= 20)
            {               
                l =  v / f;
                p = 1000 / f;
                ops = f * 2;
                opi = f / 2;
                lstLambda.Items.Add(Math.Round(l,2));
                lstPeriodo.Items.Add(Math.Round(p,10));
                lstOS.Items.Add(ops);
                lstOI.Items.Add(opi);
                if (f>=20)
                {
                    if (f>=150)
                    {
                        if(f>500)
                        {
                            if(f>1000)
                            {
                                lstCat.Items.Add("High Frequency");
                            }
                            else
                            {
                                lstCat.Items.Add("Mid Frequency");
                            }                            
                        }
                        else
                        {
                            lstCat.Items.Add("Mid-low Frequency");
                        }
                    }
                    else
                    {
                        lstCat.Items.Add("Low Frequency");
                    }                  
                }
            }
            else
            {
                MessageBox.Show("Ingrese una frecuencia entre 20 y 20000 Khz :)");
            }                                        
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDATOSTECNICOS_Click(object sender, EventArgs e)
        {
            lstCat.Items.Clear();
            lstOI.Items.Clear();
            lstOS.Items.Clear();
            lstPeriodo.Items.Clear();
            lstLambda.Items.Clear();
        }

        private void btnRever_Click(object sender, EventArgs e)
        {
            double volumen, superficie, coeficiente, tiempo;
            volumen = Convert.ToDouble(txtMetcub.Text);
            superficie = Convert.ToDouble(txtMetcua.Text);
            coeficiente = Convert.ToDouble(txtCoef.Text);
            if (coeficiente>0 || coeficiente<5)
            {
                tiempo = (0.161 * volumen) / (coeficiente * superficie);
                lstRever.Items.Add(Math.Round(tiempo, 2));
            }
            else
            {
                MessageBox.Show("Coeficiente Incorrecto");
            }


        }

        private void btnCLEARREVER_Click(object sender, EventArgs e)
        {
            lstRever.Items.Clear();
        }

        private void btnResfreq_Click(object sender, EventArgs e)
        {
            int f;
            double cuarta, lambda;
            f = Convert.ToInt32(txtFreq2.Text);
            if (f <= 20000 && f >= 20)
            {
                lambda = v / f; 
                cuarta = lambda / 4;
                lstdistpar.Items.Add(Math.Round(cuarta, 2));
                lstdistpar.Items.Add(Math.Round(cuarta*2, 2));
                lstdistpar.Items.Add(Math.Round(cuarta*4, 2));
                lstdistpar.Items.Add(Math.Round(cuarta*8, 2));
            }
            else
            {
                MessageBox.Show("Ingrese una frecuencia entre 20 y 20000 Khz :)");
            }
        }

        private void btnCLEARRESONANCIA1_Click(object sender, EventArgs e)
        {
            lstdistpar.Items.Clear();
        }

        private void btnResdist_Click(object sender, EventArgs e)
        {
            double d, f1; 
            d = Convert.ToDouble(txtdistpar.Text);
            if (d>0 && d<=80)
            {
                f1 = v / ((d/10) * 4);
                lstFreq.Items.Add(f1);
            }
            else

                MessageBox.Show("Ingrese una distancia entre 0,1 y 80 metros :)");
        }

        private void btnCLEARRESONANCIA2_Click(object sender, EventArgs e)
        {
            lstFreq.Items.Clear();
        }

        private void btnDesfase_Click(object sender, EventArgs e)
        {
            int angulo;
            angulo = Convert.ToInt32(txtAngulo.Text);
            if (angulo >=0 && angulo <=180)
            {
                if (angulo >= 0)
                {
                    if (angulo >= 38)
                    {
                        if (angulo >= 90)
                        {
                            if (angulo >= 120)
                            {
                                if (angulo >= 150)
                                {
                                    if (angulo == 180)
                                        lstDbs.Items.Add("-100 (desfase completo)");
                                }
                                else
                                lstDbs.Items.Add("-6");
                            }
                            else
                                lstDbs.Items.Add("+0");
                        }
                        else
                            lstDbs.Items.Add("+3");
                    }
                    else
                        lstDbs.Items.Add("+5.5");
                }
                else
                    lstDbs.Items.Add("+6 (fase exacta)");
            } 
            else
            {
                MessageBox.Show("Ingrese un angulo entre los valores establecidos)");
            }
        }

        private void btnCLEARDESFASE_Click(object sender, EventArgs e)
        {
            lstDbs.Items.Clear();
        }

        private void btnKbps_Click(object sender, EventArgs e)
        {
            int kbps;
            kbps = Convert.ToInt32(txtKbps.Text);
            if (kbps <= 3000)
            {
                if (kbps <= 1500)
                {
                    if (kbps <= 320)
                    {
                        if (kbps <= 270)
                        {
                            if (kbps <= 192)
                            {
                                if (kbps <= 98)
                                {
                                    lstFormat.Items.Add("Que es esto???");
                                }
                                else
                                    lstFormat.Items.Add("MP3 Posiblemente descarga de youtube, MALA CALIDAD");
                            }
                            else
                                lstFormat.Items.Add("MP3 Posible descarga de un portal de internet");
                        }
                        else
                            lstFormat.Items.Add("MP3 de la maxima calidad distribuida en el mercado, pesan al rededor de 8 Mb");
                    }
                    else
                            lstFormat.Items.Add("Archivos de tipo FLAC o Monkey's Audio, generalmente pesan mas de 20 Mb");
                }
                else
                    lstFormat.Items.Add("Archivos de la mas alta calidad WAV, sin compresion, generalmente pesan mas de 50 Mb");
            }
        }

        private void btnCLEARKBPS_Click(object sender, EventArgs e)
        {
            lstFormat.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstFormat.Items.Clear();
            lstDbs.Items.Clear();
            lstFreq.Items.Clear();
            lstCat.Items.Clear();
            lstdistpar.Items.Clear();
            lstLambda.Items.Clear();
            lstOI.Items.Clear();
            lstOS.Items.Clear();
            lstPeriodo.Items.Clear();
            lstRever.Items.Clear();
            lstVel.Items.Clear();
            txtAngulo.Clear();
            txtCoef.Clear();
            txtdistpar.Clear();
            txtFreq.Clear();
            txtFreq2.Clear();
            txtKbps.Clear();
            txtMetcua.Clear();
            txtMetcub.Clear();
            txtTemp.Clear();
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }
    }
}
