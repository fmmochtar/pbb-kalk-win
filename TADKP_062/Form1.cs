using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADKP_062
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //combobox selected index adalah pilihan pertama
            objekpajak.SelectedIndex = 0;
            tanahAB.SelectedIndex = 0;
            tanah00.SelectedIndex = 0;
            bangunan00.SelectedIndex = 0;
            bangunanAB.SelectedIndex = 0;

            //njoptkpbox.Text = Convert.ToString(njoptkp); // NJOPTKP 10 juta dimasukkan di awal program
        }

        // NJOPTKP
        //double njoptkp;

        // harga tanah kelas A
        double[] hta = new double[50] { 3100000, 2925000, 2779000, 2640000, 2508000, 2352000, 2176000, 2013000, 1862000,
        1722000, 1573000, 1416000, 1274000, 1147000, 1032000, 916000, 802000, 702000, 614000, 537000, 464000, 394000, 335000,
        285000, 243000, 243000, 200000, 160000, 128000, 103000, 82000, 64000, 48000, 36000, 27000, 20000, 14000, 10000, 7150,
        5000, 3500, 2450, 1700, 1200, 910, 660, 480, 350, 270, 200};

        // harga tanah kelas B
        double[] htb = new double[50] {68545000 ,66255000 ,64000000 ,61795000,59625000, 57495000 , 55405000 , 53355000 ,51345000 ,49375000,
        47445000 ,45555000 ,43705000 ,41895000 , 40125000, 38395000 ,36705000, 35055000, 33445000, 31875000, 30345000,28855000,27405000,25995000,24625000
        ,23295000,22005000,20755000,19545000,18375000,17245000,16155000,15105000,14095000,13125000,12195000,11305000,10455000
        ,9645000,8875000,8145000,7455000,6805000,6195000,5625000,5095000,4605000,4155000,3745000,3375000 };

        // harga bangunan kelas A
        double[] hba = new double[20] {1200000, 968000, 823000, 700000, 595000, 505000, 429000, 365000, 310000, 264000, 225000, 191000, 162000,
        132000, 116000, 98000, 83000, 71000, 60000, 50000};

        // harga bangunan kelas B
        double[] hbb = new double[20] {15250000, 14150000, 13075000, 12050000, 11075000, 10150000, 9275000, 8450000, 7675000, 6950000, 6225000,
        5500000, 4825000, 4200000, 3625000, 3100000, 2625000, 2200000, 1833000, 1516000};

        // Vars
        public double htanah;
        public double hbangunan;
        public double htotal;
        public double njkp;
        //private double pbbfinal;
        public double njopmilikpbb;
        //private double njoptkp; // lul


        private void calchrgtanahbangunan_Click_1(object sender, EventArgs e)
        {
            double lt1, lb1;
            double.TryParse(ltanah.Text, out lt1);
            double.TryParse(lbangunan.Text, out lb1);

            if (!double.TryParse(ltanah.Text, out lt1) || !double.TryParse(lbangunan.Text, out lb1))
            {
                MessageBox.Show("Mohon isi data dengan benar.");

            }
            else
            {

                if (tanahAB.SelectedItem.ToString() == "A")
                {
                    for (tanah00.SelectedIndex = tanah00.SelectedIndex; tanah00.ItemHeight == 50; tanah00.SelectedIndex++) ;


                    htanah = lt1 * hta[tanah00.SelectedIndex];
                    htanahbox.Text = Convert.ToString(htanah);

                }
                else if (tanahAB.SelectedItem.ToString() == "B")
                {

                    for (tanah00.SelectedIndex = tanah00.SelectedIndex; tanah00.ItemHeight == 50; tanah00.SelectedIndex++) ;

                    htanah = lt1 * htb[tanah00.SelectedIndex];
                    htanahbox.Text = Convert.ToString(htanah);

                }
                else if (tanahAB.SelectedItem.ToString() == null)
                {
                    htanah = 0;
                    htanahbox.Text = Convert.ToString(htanah);
                }

                if (bangunanAB.SelectedItem.ToString() == "A")
                {
                    for (bangunan00.SelectedIndex = bangunan00.SelectedIndex; bangunan00.ItemHeight == 20; bangunan00.SelectedIndex++) ;

                    hbangunan = lb1 * hba[bangunan00.SelectedIndex];
                    hbangunanbox.Text = Convert.ToString(hbangunan);

                }
                else if (bangunanAB.SelectedItem.ToString() == "B")
                {
                    for (bangunan00.SelectedIndex = bangunan00.SelectedIndex; bangunan00.ItemHeight == 20; bangunan00.SelectedIndex++) ;

                    hbangunan = lb1 * hbb[bangunan00.SelectedIndex];
                    hbangunanbox.Text = Convert.ToString(hbangunan);

                }
                else if (bangunanAB.SelectedItem.ToString() == null)
                {
                    hbangunan = 0;
                    hbangunanbox.Text = Convert.ToString(hbangunan);
                }
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ltanah.Text = "";
            lbangunan.Text = "";
            htanahbox.Text = "";
            hbangunanbox.Text = "";
            njopbox.Text = "";
            njkpbox.Text = "";
            pbbbox.Text = "";
            njoptkpbox.Text = "";
            tanahAB.Text = "";
            tanah00.Text = "";
            bangunan00.Text = "";
            bangunanAB.Text = "";
            njkppersen.Text = "(  %)";
            njopppbb.Text = "";

            objekpajak.SelectedIndex = 0;
            tanahAB.SelectedIndex = 0;
            tanah00.SelectedIndex = 0;
            bangunan00.SelectedIndex = 0;
            bangunanAB.SelectedIndex = 0;
        }

        private void clear_njop_Click(object sender, EventArgs e)
        {
            njopbox.Text = "";
            njopppbb.Text = "";
        }

        private void clear_hthb_Click(object sender, EventArgs e)
        {
            ltanah.Text = "";
            lbangunan.Text = "";
            htanahbox.Text = "";
            hbangunanbox.Text = "";
        }

        private void clear_totalnjop_Click(object sender, EventArgs e)
        {
            njopbox.Text = "";
            njoptkpbox.Text = "";
            njopppbb.Text = "";
        }

        private void clear_njkppbb_Click(object sender, EventArgs e)
        {
            njkpbox.Text = "";
            njkppersen.Text = "(  %)";
            pbbbox.Text = "";
        }

        private void njopplus_Click(object sender, EventArgs e)
        {
            double njoptkp;
            double.TryParse(njoptkpbox.Text, out njoptkp);
            if (!double.TryParse(njoptkpbox.Text, out njoptkp))
            {
                MessageBox.Show("Mohon isi data dengan benar.");
            }
            else
            {
                htotal = htanah + hbangunan;
                njopbox.Text = Convert.ToString(htotal);

                njopmilikpbb = htotal - njoptkp;
                njopppbb.Text = Convert.ToString(njopmilikpbb);
            }
        }

        private void njopppbb_TextChanged(object sender, EventArgs e)
        {

        }

        private void objekpajak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void njkppbbklik_Click(object sender, EventArgs e)
        {
            double njoptkp;
            double.TryParse(njoptkpbox.Text, out njoptkp);
            if (!double.TryParse(njoptkpbox.Text, out njoptkp))
            {
                MessageBox.Show("Mohon isi data dengan benar.");
            }
            else
            {
                if (objekpajak.SelectedItem.ToString() == "Pertambangan" || objekpajak.SelectedItem.ToString() == "Perkebunan" || objekpajak.SelectedItem.ToString() == "Kehutanan")
                {
                    njkp = (htotal - njoptkp) * 0.4f;
                    njkpbox.Text = Convert.ToString(njkp);
                    njkppersen.Text = "(40%)";
                }
                else if (objekpajak.SelectedItem.ToString() == "Lainnya (pedesaan dan perkotaan)")
                {
                    if (htotal >= 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.4f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(40%)";
                    }
                    else if (htotal < 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.2f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(20%)";
                    }

                }
                hitungpbb pbb = new hitungpbb();

                pbb.hitungpbbnya(njkp);

                //pbbfinal = 0.005f * njkp;
                pbb.hasilhitungpbb();

                pbbbox.Text = Convert.ToString(pbb.hasilhitungpbb());
            }
        }

        private void jopdantkpplus_Click(object sender, EventArgs e)
        {
            double njoptkp;
            double.TryParse(njoptkpbox.Text, out njoptkp);
            if (!double.TryParse(njoptkpbox.Text, out njoptkp))
            {
                MessageBox.Show("Mohon isi data dengan benar.");
            }
            else
            {
                if (objekpajak.SelectedItem.ToString() == "Pertambangan" || objekpajak.SelectedItem.ToString() == "Perkebunan" || objekpajak.SelectedItem.ToString() == "Kehutanan")
                {
                    njkp = (htotal - njoptkp) * 0.4f;
                    njkpbox.Text = Convert.ToString(Math.Round(njkp));
                    njkppersen.Text = "(40%)";
                }
                else if (objekpajak.SelectedItem.ToString() == "Lainnya (pedesaan dan perkotaan)")
                {
                    if (htotal >= 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.4f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(40%)";
                    }
                    else if (htotal < 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.2f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(20%)";
                    }

                }

                njopmilikpbb = htotal - njoptkp;
                njopppbb.Text = Convert.ToString(njopmilikpbb);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Block any alphabet inputs from textboxes
        private void ltanah_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lbangunan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void htanahbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void hbangunanbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void njopbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void njopppbb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void njoptkpbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void njkpbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void pbbbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void njoptkpbox_TextChanged(object sender, EventArgs e)
        {

        }

        // Hitung semuanya

        private void button1_Click(object sender, EventArgs e)
        {
            double lt1, lb1;
            double njoptkp;
            double.TryParse(ltanah.Text, out lt1);
            double.TryParse(lbangunan.Text, out lb1);
            double.TryParse(njoptkpbox.Text, out njoptkp);

            if (!double.TryParse(ltanah.Text, out lt1) || !double.TryParse(lbangunan.Text, out lb1) || !double.TryParse(njoptkpbox.Text, out njoptkp))
            {
                MessageBox.Show("Mohon isi data dengan benar.");
            }

            else
            {

                if (tanahAB.SelectedItem.ToString() == "A")
                {
                    for (tanah00.SelectedIndex = tanah00.SelectedIndex; tanah00.ItemHeight == 50; tanah00.SelectedIndex++) ;


                    htanah = lt1 * hta[tanah00.SelectedIndex];
                    htanahbox.Text = Convert.ToString(htanah);

                }
                else if (tanahAB.SelectedItem.ToString() == "B")
                {

                    for (tanah00.SelectedIndex = tanah00.SelectedIndex; tanah00.ItemHeight == 50; tanah00.SelectedIndex++) ;

                    htanah = lt1 * htb[tanah00.SelectedIndex];
                    htanahbox.Text = Convert.ToString(htanah);

                }
                else if (tanahAB.SelectedItem.ToString() == null)
                {
                    htanah = 0;
                    htanahbox.Text = Convert.ToString(htanah);
                }

                if (bangunanAB.SelectedItem.ToString() == "A")
                {
                    for (bangunan00.SelectedIndex = bangunan00.SelectedIndex; bangunan00.ItemHeight == 20; bangunan00.SelectedIndex++) ;

                    hbangunan = lb1 * hba[bangunan00.SelectedIndex];
                    hbangunanbox.Text = Convert.ToString(hbangunan);

                }
                else if (bangunanAB.SelectedItem.ToString() == "B")
                {
                    for (bangunan00.SelectedIndex = bangunan00.SelectedIndex; bangunan00.ItemHeight == 20; bangunan00.SelectedIndex++) ;

                    hbangunan = lb1 * hbb[bangunan00.SelectedIndex];
                    hbangunanbox.Text = Convert.ToString(hbangunan);

                }
                else if (bangunanAB.SelectedItem.ToString() == null)
                {
                    hbangunan = 0;
                    hbangunanbox.Text = Convert.ToString(hbangunan);
                }


                htotal = htanah + hbangunan;
                njopbox.Text = Convert.ToString(htotal);

                njopmilikpbb = htotal - njoptkp;
                njopppbb.Text = Convert.ToString(njopmilikpbb);

                if (objekpajak.SelectedItem.ToString() == "Pertambangan" || objekpajak.SelectedItem.ToString() == "Perkebunan" || objekpajak.SelectedItem.ToString() == "Kehutanan")
                {
                    njkp = (htotal - njoptkp) * 0.4f;
                    njkpbox.Text = Convert.ToString(Math.Round(njkp));
                    njkppersen.Text = "(40%)";
                }
                else if (objekpajak.SelectedItem.ToString() == "Lainnya (pedesaan dan perkotaan)")
                {
                    if (htotal >= 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.4f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(40%)";
                    }
                    else if (htotal < 1000000000)
                    {
                        njkp = (htotal - njoptkp) * 0.2f;
                        njkpbox.Text = Convert.ToString(Math.Round(njkp));
                        njkppersen.Text = "(20%)";
                    }

                }

                hitungpbb pbb = new hitungpbb();

                pbb.hitungpbbnya(njkp);

                //pbbfinal = 0.005f * njkp;
                pbb.hasilhitungpbb();

                pbbbox.Text = Convert.ToString(pbb.hasilhitungpbb());
            }

        }

        private void resetkelas_Click(object sender, EventArgs e)
        {
            tanahAB.SelectedIndex = 0;
            tanah00.SelectedIndex = 0;
            bangunan00.SelectedIndex = 0;
            bangunanAB.SelectedIndex = 0;
        }
    }

}