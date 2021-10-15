using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace mandelbrotlayout
{
    public partial class MandelbrotForm : Form
    {
        //Declaraties van enkle integers en doubles.
        double Xmid = 0.00, Ymid = 0.00, schaal = 4.00;       
        int breedte, hoogte, xscherm, yscherm, Mandelbrotgetal, MBgetalMax = 100;
        
        public MandelbrotForm()
        {
            //Roept static main aan en kent de string toe die in de textboxen moet komen te staan
            InitializeComponent();
            Mandelbrotpanel.MouseClick += Zoom;
            Max.Text = Convert.ToString(MBgetalMax);
            Schaalbox.Text = Convert.ToString(4.00);
            MiddenX.Text = Convert.ToString(Xmid);
            MiddenY.Text = Convert.ToString(Ymid);
        }

        private void Mandelbrotpanel_paint(object o, PaintEventArgs pea)
        {
            MandelbrotSet(o, pea);
            MandelbrotCalc(xscherm, yscherm, breedte, hoogte, MBgetalMax, Xmid, Ymid);
        }

        public void MandelbrotSet(object o, PaintEventArgs pea) //Deze methode tekent de mandelbrot.
        {
            breedte = Mandelbrotpanel.Width;
            hoogte = Mandelbrotpanel.Height;
            //Met de for loops wordt er voor elke x en y één pixel getekend.
            for (int xscherm = 0; xscherm < breedte; xscherm++) 
            {
                for (int yscherm = 0; yscherm < hoogte; yscherm++)
                {
                    int Mandelbrotgetal = MandelbrotCalc(xscherm, yscherm, breedte, hoogte, MBgetalMax,  Xmid, Ymid);

                    if (Mandelbrotgetal < MBgetalMax)
                    {
                        /*de kleur hangt af van het mandelbrot getal en van de waardes van het RGBtrackpad,
                        de waardes: "10", "5" en "7" bepalen de intesntiteit van de RGB waarde.  */
                        Color c1 = Color.FromArgb((Mandelbrotgetal * 10 % (RGBRood.Value + 1)), (Mandelbrotgetal * 5 % (RGBGroen.Value + 1)), ((Mandelbrotgetal * 7 % (RGBBlauw.Value + 1))));
                        Brush b = new SolidBrush(c1);
                        pea.Graphics.FillRectangle(b, xscherm, yscherm, 1, 1);
                    }
                    else
                    {
                        // waneer het mandelbrotgetal buiten het maximum valt wordt er een zwarte pixel getekend.
                        pea.Graphics.FillRectangle(Brushes.Black, xscherm, yscherm, 1, 1);
                    }
                }
            }
        }

        public int MandelbrotCalc(int xscherm, int yscherm, int breedte, int hoogte, int MBgetalMax, double Xmid, double Ymid)
        {
            //In deze methode wordt het Mandelbrot getal berekent, met behulp van de formule en de while opdracht.
            double a = 0, b = 0;
            int Mandelbrotgetal = 0;

            double Afloat = (xscherm - breedte / 2) * schaal / (breedte - 1) + Xmid;
            double Bfloat = (yscherm - hoogte / 2) * schaal / (hoogte - 1) + Ymid;
            //de while opdracht wordt uitgevoerd waneer de afstand kleiner is dan 2, en het mandelbrotgetal kleiner is dan het maximum mandelbrotgetal.
            while (Math.Sqrt((a * a) + (b * b)) < 2 && Mandelbrotgetal < MBgetalMax)
            {
                double newA = (a * a) - (b * b) + Afloat;
                double newB = (2 * a * b) + Bfloat;
                a = newA;
                b = newB;
                Mandelbrotgetal++;
            }
            return Mandelbrotgetal;
        }
        void Zoom(Object o, MouseEventArgs mea)
        {
            //Wanneer iemand op de linker muisknop klikt, worden de nieuwe coördinaten van het midden bepaalt en wordt er een keer ingezoomd.
            if (mea.Button == MouseButtons.Left)
            {
                double minX = Xmid - (schaal / 2);
                double minY = Ymid - (schaal / 2);
                Xmid = minX + (double)mea.X / Mandelbrotpanel.Width * schaal;
                Ymid = minY + (double)mea.Y / Mandelbrotpanel.Height * schaal;
                schaal = schaal / 2;
                Mandelbrotpanel.Invalidate();
            }
            //Wanneer iemand op de rechter muisknop klikt, worden de nieuwe coördinaten van het midden bepaalt en wordt er een keer ingezoomd.
            if (mea.Button == MouseButtons.Right)
            {
                double minX = Xmid - (schaal / 2);
                double minY = Ymid - (schaal / 2);
                Xmid = minX + (double)mea.X / Mandelbrotpanel.Width * schaal;
                Ymid = minY + (double)mea.Y / Mandelbrotpanel.Height * schaal;
                schaal = schaal * 2;
                Mandelbrotpanel.Invalidate();
            }
            Max.Text = Convert.ToString(MBgetalMax);
            Schaalbox.Text = Convert.ToString(schaal);
            MiddenX.Text = Convert.ToString(Xmid);
            MiddenY.Text = Convert.ToString(Ymid);
        }
        private void OK_Click(object o, EventArgs e)
        { //De try en catch opdracht controleert of er daadwerkelijke een getal wordt in gevuld en niet een karakter.
            try
            {
                Xmid = double.Parse(MiddenX.Text);
                Ymid = double.Parse(MiddenY.Text);
                schaal = double.Parse(Schaalbox.Text);
                MBgetalMax = int.Parse(Max.Text);
            }
            catch
            { 
                MessageBox.Show("Er moeten getallen ingevoerd worden.");
            }
            Mandelbrotpanel.Invalidate();
        }
        
        private void Reset_Click(object o, EventArgs e)
        {
            //Wanneer er op de Reset knop wordt gedrukt, verander alle waarden van locatie en schaal weer naar de standaard waarden (kleur dus niet).
            schaal = 4.0;
            Xmid = 0;
            Ymid = 0;
            MBgetalMax = 100;
            Max.Text = Convert.ToString(MBgetalMax);
            Schaalbox.Text = Convert.ToString(schaal);
            MiddenX.Text = Convert.ToString(Xmid);
            MiddenY.Text = Convert.ToString(Ymid);
            RoodWaarde.Text = RGBRood.Value.ToString();
            GroenWaarde.Text = RGBGroen.Value.ToString();
            BlauwWaarde.Text = RGBBlauw.Value.ToString();
            Mandelbrotpanel.Invalidate();
        }
        public void RGB_Trackpad(object o, EventArgs e)
        { 
            //Hier worden de waardes in het textbox van de RGBTrackpads mee geupdate, terwijl er met de trackbar gesleept wordt.
            RoodWaarde.Text = RGBRood.Value.ToString();
            GroenWaarde.Text = RGBGroen.Value.ToString();
            BlauwWaarde.Text = RGBBlauw.Value.ToString();
        }

        private void Keuzelijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hier worden alle waarden van de presets gedeclareert en geupdate in de textboxen.
            if(Keuzelijst.SelectedIndex == 0)
            {
                //preset Standaar
                schaal = 4.0;
                Xmid = 0;
                Ymid = 0;
                MBgetalMax = 100;
                Max.Text = Convert.ToString(MBgetalMax);
                Schaalbox.Text = Convert.ToString(schaal);
                MiddenX.Text = Convert.ToString(Xmid);
                MiddenY.Text = Convert.ToString(Ymid);
                RGBRood.Value = 255;
                RGBGroen.Value = 0;
                RGBBlauw.Value = 0;
                RoodWaarde.Text = RGBRood.Value.ToString();
                GroenWaarde.Text = RGBGroen.Value.ToString();
                BlauwWaarde.Text = RGBBlauw.Value.ToString();
            }
            if(Keuzelijst.SelectedIndex == 1)
            {
                //preset het blauwe oog
                schaal = 2.38418579101563E-07;
                Xmid = -0.137111397743225; 
                Ymid = -1.00510456132108;
                MBgetalMax = 200;
                Max.Text = Convert.ToString(MBgetalMax);
                Schaalbox.Text = Convert.ToString(schaal);
                MiddenX.Text = Convert.ToString(Xmid);
                MiddenY.Text = Convert.ToString(Ymid);
                RGBRood.Value = 18;
                RGBGroen.Value = 98;
                RGBBlauw.Value = 139;
                RoodWaarde.Text = RGBRood.Value.ToString();
                GroenWaarde.Text = RGBGroen.Value.ToString();
                BlauwWaarde.Text = RGBBlauw.Value.ToString();
            }
            if (Keuzelijst.SelectedIndex == 2)
            {
                //preset Koraal
                schaal = 3.0E-5;
                Xmid = -0.745428;
                Ymid = 0.113009;
                MBgetalMax = 1000;
                Max.Text = Convert.ToString(MBgetalMax);
                Schaalbox.Text = Convert.ToString(schaal);
                MiddenX.Text = Convert.ToString(Xmid);
                MiddenY.Text = Convert.ToString(Ymid);
                RGBRood.Value = 0;
                RGBGroen.Value = 134;
                RGBBlauw.Value = 85;
                RoodWaarde.Text = RGBRood.Value.ToString();
                GroenWaarde.Text = RGBGroen.Value.ToString();
                BlauwWaarde.Text = RGBBlauw.Value.ToString();
            }
            if (Keuzelijst.SelectedIndex == 3)
            {
                // preset Herfst
                schaal = 0.00244140625;
                Xmid = -1.78600390625;
                Ymid = -1.40080686476538E-05;
                MBgetalMax = 150;
                Max.Text = Convert.ToString(MBgetalMax);
                Schaalbox.Text = Convert.ToString(schaal);
                MiddenX.Text = Convert.ToString(Xmid);
                MiddenY.Text = Convert.ToString(Ymid);
                RGBRood.Value = 255;
                RGBGroen.Value = 85;
                RGBBlauw.Value = 75;
                RoodWaarde.Text = RGBRood.Value.ToString();
                GroenWaarde.Text = RGBGroen.Value.ToString();
                BlauwWaarde.Text = RGBBlauw.Value.ToString();
            }
            if (Keuzelijst.SelectedIndex == 4)
            {
                //preset Corona
                schaal = 1.81898940354585E-12;
                Xmid = -1.61290030805554;
                Ymid = -0.00126504338520111;
                MBgetalMax = 300;
                Max.Text = Convert.ToString(MBgetalMax);
                Schaalbox.Text = Convert.ToString(schaal);
                MiddenX.Text = Convert.ToString(Xmid);
                MiddenY.Text = Convert.ToString(Ymid);
                RGBRood.Value = 0;
                RGBGroen.Value = 130;
                RGBBlauw.Value = 0;
                RoodWaarde.Text = RGBRood.Value.ToString();
                GroenWaarde.Text = RGBGroen.Value.ToString();
                BlauwWaarde.Text = RGBBlauw.Value.ToString();
            }
            Mandelbrotpanel.Invalidate();
        }
    }
}
