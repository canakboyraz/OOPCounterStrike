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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bizim Form";
            cephane = new Cephane();
            cephane.MyWeapons[0] = new Bicak("XS5500", "Rambo", 0.5);
            cephane.MyWeapons[1] = new Tabanca("Magnum", "6 Patlar", 3.4, false, 30, false);
            cephane.MyWeapons[2] = new Tufek("SuperPoze", "Bindirmeli", 4, false, 90, false,TufekTipi.PompaliTufek);
            cephane.MyWeapons[3] = new Tufek("Uzi", "Uzi500", 2, true, 50, true,TufekTipi.TaramaliTufek);
            cephane.MyWeapons[4] = new Top("MKE", "Kafa1500", 6500);

            pictureBox1.Image = cephane.SilahDegis(1); // Býçak resmi geliyor.

            Form1_KeyPress(this, new KeyPressEventArgs('1')); // Form Load olurken 1 e basýlmýþ gibi devralsýn.
            this.Focus();

           


        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnYakinlastir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBileyle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
