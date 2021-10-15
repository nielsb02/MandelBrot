namespace mandelbrotlayout
{
    partial class MandelbrotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mandelbrotpanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OK = new System.Windows.Forms.Button();
            this.MiddenX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MiddenY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Schaalbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.RGBRood = new System.Windows.Forms.TrackBar();
            this.RGBGroen = new System.Windows.Forms.TrackBar();
            this.RGBBlauw = new System.Windows.Forms.TrackBar();
            this.Rood = new System.Windows.Forms.Label();
            this.Groen = new System.Windows.Forms.Label();
            this.Blauw = new System.Windows.Forms.Label();
            this.RoodWaarde = new System.Windows.Forms.Label();
            this.GroenWaarde = new System.Windows.Forms.Label();
            this.BlauwWaarde = new System.Windows.Forms.Label();
            this.Keuzelijst = new System.Windows.Forms.ListBox();
            this.Mandelbrotpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBRood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBlauw)).BeginInit();
            this.SuspendLayout();
            // 
            // Mandelbrotpanel
            // 
            this.Mandelbrotpanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Mandelbrotpanel.Controls.Add(this.flowLayoutPanel1);
            this.Mandelbrotpanel.Location = new System.Drawing.Point(204, 0);
            this.Mandelbrotpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mandelbrotpanel.Name = "Mandelbrotpanel";
            this.Mandelbrotpanel.Size = new System.Drawing.Size(667, 600);
            this.Mandelbrotpanel.TabIndex = 0;
            this.Mandelbrotpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mandelbrotpanel_paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(84, 42);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(11, 486);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(187, 30);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // MiddenX
            // 
            this.MiddenX.Location = new System.Drawing.Point(10, 128);
            this.MiddenX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MiddenX.Name = "MiddenX";
            this.MiddenX.Size = new System.Drawing.Size(187, 22);
            this.MiddenX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Midden X:";
            // 
            // MiddenY
            // 
            this.MiddenY.Location = new System.Drawing.Point(10, 171);
            this.MiddenY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MiddenY.Name = "MiddenY";
            this.MiddenY.Size = new System.Drawing.Size(187, 22);
            this.MiddenY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Midden Y:";
            // 
            // Schaalbox
            // 
            this.Schaalbox.Location = new System.Drawing.Point(11, 214);
            this.Schaalbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Schaalbox.Name = "Schaalbox";
            this.Schaalbox.Size = new System.Drawing.Size(187, 22);
            this.Schaalbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Schaal:";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(11, 257);
            this.Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(187, 22);
            this.Max.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max:";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(11, 522);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(187, 30);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // RGBRood
            // 
            this.RGBRood.Location = new System.Drawing.Point(10, 301);
            this.RGBRood.Maximum = 255;
            this.RGBRood.Name = "RGBRood";
            this.RGBRood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGBRood.Size = new System.Drawing.Size(188, 56);
            this.RGBRood.TabIndex = 11;
            this.RGBRood.Value = 255;
            this.RGBRood.Scroll += new System.EventHandler(this.RGB_Trackpad);
            // 
            // RGBGroen
            // 
            this.RGBGroen.Location = new System.Drawing.Point(10, 363);
            this.RGBGroen.Maximum = 255;
            this.RGBGroen.Name = "RGBGroen";
            this.RGBGroen.Size = new System.Drawing.Size(188, 56);
            this.RGBGroen.TabIndex = 12;
            this.RGBGroen.Scroll += new System.EventHandler(this.RGB_Trackpad);
            // 
            // RGBBlauw
            // 
            this.RGBBlauw.Location = new System.Drawing.Point(10, 425);
            this.RGBBlauw.Maximum = 255;
            this.RGBBlauw.Name = "RGBBlauw";
            this.RGBBlauw.Size = new System.Drawing.Size(188, 56);
            this.RGBBlauw.TabIndex = 13;
            this.RGBBlauw.Scroll += new System.EventHandler(this.RGB_Trackpad);
            // 
            // Rood
            // 
            this.Rood.AutoSize = true;
            this.Rood.Location = new System.Drawing.Point(18, 290);
            this.Rood.Name = "Rood";
            this.Rood.Size = new System.Drawing.Size(42, 17);
            this.Rood.TabIndex = 14;
            this.Rood.Text = "Rood";
            // 
            // Groen
            // 
            this.Groen.AutoSize = true;
            this.Groen.Location = new System.Drawing.Point(18, 343);
            this.Groen.Name = "Groen";
            this.Groen.Size = new System.Drawing.Size(48, 17);
            this.Groen.TabIndex = 15;
            this.Groen.Text = "Groen";
            // 
            // Blauw
            // 
            this.Blauw.AutoSize = true;
            this.Blauw.Location = new System.Drawing.Point(15, 405);
            this.Blauw.Name = "Blauw";
            this.Blauw.Size = new System.Drawing.Size(45, 17);
            this.Blauw.TabIndex = 16;
            this.Blauw.Text = "Blauw";
            // 
            // RoodWaarde
            // 
            this.RoodWaarde.AutoSize = true;
            this.RoodWaarde.Location = new System.Drawing.Point(150, 290);
            this.RoodWaarde.Name = "RoodWaarde";
            this.RoodWaarde.Size = new System.Drawing.Size(32, 17);
            this.RoodWaarde.TabIndex = 17;
            this.RoodWaarde.Text = "250";
            // 
            // GroenWaarde
            // 
            this.GroenWaarde.AutoSize = true;
            this.GroenWaarde.Location = new System.Drawing.Point(166, 343);
            this.GroenWaarde.Name = "GroenWaarde";
            this.GroenWaarde.Size = new System.Drawing.Size(16, 17);
            this.GroenWaarde.TabIndex = 18;
            this.GroenWaarde.Text = "0";
            // 
            // BlauwWaarde
            // 
            this.BlauwWaarde.AutoSize = true;
            this.BlauwWaarde.Location = new System.Drawing.Point(166, 405);
            this.BlauwWaarde.Name = "BlauwWaarde";
            this.BlauwWaarde.Size = new System.Drawing.Size(16, 17);
            this.BlauwWaarde.TabIndex = 19;
            this.BlauwWaarde.Text = "0";
            // 
            // Keuzelijst
            // 
            this.Keuzelijst.FormattingEnabled = true;
            this.Keuzelijst.ItemHeight = 16;
            this.Keuzelijst.Items.AddRange(new object[] {
            "Standaard",
            "Het boze oog",
            "Koraal",
            "Herfst",
            "Corona"});
            this.Keuzelijst.Location = new System.Drawing.Point(6, 11);
            this.Keuzelijst.Name = "Keuzelijst";
            this.Keuzelijst.Size = new System.Drawing.Size(190, 84);
            this.Keuzelijst.TabIndex = 20;
            this.Keuzelijst.SelectedIndexChanged += new System.EventHandler(this.Keuzelijst_SelectedIndexChanged);
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(869, 595);
            this.Controls.Add(this.Keuzelijst);
            this.Controls.Add(this.BlauwWaarde);
            this.Controls.Add(this.GroenWaarde);
            this.Controls.Add(this.RoodWaarde);
            this.Controls.Add(this.Blauw);
            this.Controls.Add(this.Groen);
            this.Controls.Add(this.Rood);
            this.Controls.Add(this.RGBBlauw);
            this.Controls.Add(this.RGBGroen);
            this.Controls.Add(this.RGBRood);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Schaalbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MiddenY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MiddenX);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Mandelbrotpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MandelbrotForm";
            this.Text = "Mandelbrot";
            this.Mandelbrotpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGBRood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBlauw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Mandelbrotpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox MiddenX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MiddenY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Schaalbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TrackBar RGBRood;
        private System.Windows.Forms.TrackBar RGBGroen;
        private System.Windows.Forms.TrackBar RGBBlauw;
        private System.Windows.Forms.Label Rood;
        private System.Windows.Forms.Label Groen;
        private System.Windows.Forms.Label Blauw;
        private System.Windows.Forms.Label RoodWaarde;
        private System.Windows.Forms.Label GroenWaarde;
        private System.Windows.Forms.Label BlauwWaarde;
        private System.Windows.Forms.ListBox Keuzelijst;
    }
}

