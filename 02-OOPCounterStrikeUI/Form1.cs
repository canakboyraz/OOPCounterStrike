using _01_OOPCounterStrikeLibrary.Abstract;
using _01_OOPCounterStrikeLibrary.Concrete;
using _01_OOPCounterStrikeLibrary.Enum;

namespace _02_OOPCounterStrikeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cephane cephane = new Cephane();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bizim Form";
            cephane = new Cephane();
            cephane.MyWeapons[0] = new Bicak("XS5500", "Rambo", 0.5);
            cephane.MyWeapons[1] = new Tabanca("Magnum", "6 Patlar", 3.4, false, 30, false);
            cephane.MyWeapons[2] = new Tufek("SuperPoze", "Bindirmeli", 4, false, 90, false,TufekTipi.PompaliTufek);
            cephane.MyWeapons[3] = new Tufek("Uzi", "Uzi500", 2, true, 50, true,TufekTipi.TaramaliTufek);
            cephane.MyWeapons[4] = new Top("MKE", "Kafa1500", 6500);
            cephane.MyWeapons[5] = new Havan("TR", "ModelHavan", 8000);

            pictureBox1.Image = cephane.SilahDegis(1); // B��ak resmi geliyor.

            Form1_KeyPress(this, new KeyPressEventArgs('1')); // Form Load olurken 1 e bas�lm�� gibi devrals�n.
            this.Focus();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            int gelenDeger = Convert.ToInt32(e.KeyChar.ToString());
            if (gelenDeger < 7 && gelenDeger > 0) // 1 - 6 aras�nda bas�l�nca �al���cak
            {
                pictureBox1.Image = cephane.SilahDegis(gelenDeger);
                pictureBox1.Tag = gelenDeger - 1; // Dizinin i�indeki hangi indis oldu�unu tutar�m.

                if (gelenDeger == 1)
                {
                    grpKesici.Visible = true;
                    grpAtesli.Visible = false;
                    grpSarjor.Visible = false;
                }
                else // 2,3,4,5,6 bas�nca �al���r ( ate�li silah )
                {
                    grpKesici.Visible = false;
                    grpAtesli.Visible = true;
                    grpSarjor.Visible = true;

                    RefreshProgressBar();
                    /*
                    if ((cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).DurbunluMu)
                    {
                        btnYakinlastir.Visible = btnUzaklastir.Visible = true;
                    }
                    else
                    {
                        btnYakinlastir.Visible = btnUzaklastir.Visible = false;
                    }
                    */

                    btnYakinlastir.Visible = btnUzaklastir.Visible = (cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir).DurbunluMu;
                }
            }
            else
            {
                MessageBox.Show("1-6 aras� se�im yap�n");
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RefreshProgressBar()
        {
            int gelenIndis = Convert.ToInt32(pictureBox1.Tag); // B��ak se�ili ise 0. indis gelecek

            Silah silah = cephane.MyWeapons[gelenIndis];
            AtesliSilah atesli = silah as AtesliSilah;
            int maxMermiSayisi = atesli.MaxMermiSayisi;
            progressBar1.Maximum = maxMermiSayisi;
            progressBar1.Value = atesli.MermiAdet;
            progressBar1.Refresh();

           // progressBar1.Maximum = (cephane.MyWeapons[gelenIndis] as AtesliSilah).MaxMermiSayisi;
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            IAtes ates = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtes;
            MessageBox.Show(ates.AtesEt());
            RefreshProgressBar();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {    
            IAtes ates = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IAtes;
            MessageBox.Show(ates.Doldur());
            RefreshProgressBar();
        }

        private void btnYakinlastir_Click(object sender, EventArgs e)
        {
            IYakinlastir yakinlik = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir;
            MessageBox.Show(yakinlik.Yakinlastir());
        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            IYakinlastir yakinlik = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IYakinlastir;
            MessageBox.Show(yakinlik.Uzaklastir());
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            // B��a��n kes metodunu �al��t�raca��m.

            IKesici bicak = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici;
            MessageBox.Show(bicak.Kes());
        }

        private void btnBileyle_Click(object sender, EventArgs e)
        {
            IKesici bicak = cephane.MyWeapons[Convert.ToInt32(pictureBox1.Tag)] as IKesici;
            MessageBox.Show(bicak.Bileyle());
        }
    }
}
