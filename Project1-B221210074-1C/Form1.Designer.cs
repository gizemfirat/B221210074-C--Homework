namespace Project1_B221210074_1C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DR = new System.Windows.Forms.Button();
            this.DH = new System.Windows.Forms.Button();
            this.RR = new System.Windows.Forms.Button();
            this.RH = new System.Windows.Forms.Button();
            this.HH = new System.Windows.Forms.Button();
            this.DSP = new System.Windows.Forms.Button();
            this.DRP = new System.Windows.Forms.Button();
            this.DC = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.SPSP = new System.Windows.Forms.Button();
            this.SPC = new System.Windows.Forms.Button();
            this.SFSP = new System.Windows.Forms.Button();
            this.SFRP = new System.Windows.Forms.Button();
            this.SFC = new System.Windows.Forms.Button();
            this.SPRP = new System.Windows.Forms.Button();
            this.RPRP = new System.Windows.Forms.Button();
            this.controlChoice = new System.Windows.Forms.NumericUpDown();
            this.shape1X = new System.Windows.Forms.NumericUpDown();
            this.pnlShape1 = new System.Windows.Forms.Panel();
            this.He1 = new System.Windows.Forms.Label();
            this.Dep1 = new System.Windows.Forms.Label();
            this.Wid1 = new System.Windows.Forms.Label();
            this.Rad1 = new System.Windows.Forms.Label();
            this.Z1 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.shape1He = new System.Windows.Forms.NumericUpDown();
            this.shape1Dep = new System.Windows.Forms.NumericUpDown();
            this.shape1Wid = new System.Windows.Forms.NumericUpDown();
            this.shape1Rad = new System.Windows.Forms.NumericUpDown();
            this.shape1Z = new System.Windows.Forms.NumericUpDown();
            this.shape1Y = new System.Windows.Forms.NumericUpDown();
            this.pnlShape2 = new System.Windows.Forms.Panel();
            this.He2 = new System.Windows.Forms.Label();
            this.Dep2 = new System.Windows.Forms.Label();
            this.Wid2 = new System.Windows.Forms.Label();
            this.Rad2 = new System.Windows.Forms.Label();
            this.Z2 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.shape2He = new System.Windows.Forms.NumericUpDown();
            this.shape2Dep = new System.Windows.Forms.NumericUpDown();
            this.shape2Wid = new System.Windows.Forms.NumericUpDown();
            this.shape2Rad = new System.Windows.Forms.NumericUpDown();
            this.shape2Z = new System.Windows.Forms.NumericUpDown();
            this.shape2Y = new System.Windows.Forms.NumericUpDown();
            this.shape2X = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.collisionResult = new System.Windows.Forms.Label();
            this.drawShapes = new System.Windows.Forms.Panel();
            this.pnl3dShape = new System.Windows.Forms.Panel();
            this.firstShapeTag = new System.Windows.Forms.Label();
            this.secondShapeTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1X)).BeginInit();
            this.pnlShape1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shape1He)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Wid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Rad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Y)).BeginInit();
            this.pnlShape2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shape2He)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Wid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Rad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2X)).BeginInit();
            this.SuspendLayout();
            // 
            // DR
            // 
            this.DR.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DR.Location = new System.Drawing.Point(12, 12);
            this.DR.Name = "DR";
            this.DR.Size = new System.Drawing.Size(285, 25);
            this.DR.TabIndex = 0;
            this.DR.Text = "Dot-Rectangle Collision";
            this.DR.UseVisualStyleBackColor = true;
            this.DR.Click += new System.EventHandler(this.DR_Click);
            // 
            // DH
            // 
            this.DH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DH.Location = new System.Drawing.Point(12, 43);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(285, 25);
            this.DH.TabIndex = 1;
            this.DH.Text = "Dot-Hoop Collision";
            this.DH.UseVisualStyleBackColor = true;
            this.DH.Click += new System.EventHandler(this.DH_Click);
            // 
            // RR
            // 
            this.RR.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RR.Location = new System.Drawing.Point(12, 74);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(285, 25);
            this.RR.TabIndex = 2;
            this.RR.Text = "Rectangle-Rectangle Collision";
            this.RR.UseVisualStyleBackColor = true;
            this.RR.Click += new System.EventHandler(this.RR_Click);
            // 
            // RH
            // 
            this.RH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RH.Location = new System.Drawing.Point(12, 105);
            this.RH.Name = "RH";
            this.RH.Size = new System.Drawing.Size(285, 25);
            this.RH.TabIndex = 3;
            this.RH.Text = "Rectangle-Hoop Collision";
            this.RH.UseVisualStyleBackColor = true;
            this.RH.Click += new System.EventHandler(this.RH_Click);
            // 
            // HH
            // 
            this.HH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HH.Location = new System.Drawing.Point(12, 136);
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(285, 25);
            this.HH.TabIndex = 4;
            this.HH.Text = "Hoop-Hoop Collision";
            this.HH.UseVisualStyleBackColor = true;
            this.HH.Click += new System.EventHandler(this.HH_Click);
            // 
            // DSP
            // 
            this.DSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DSP.Location = new System.Drawing.Point(12, 167);
            this.DSP.Name = "DSP";
            this.DSP.Size = new System.Drawing.Size(285, 25);
            this.DSP.TabIndex = 5;
            this.DSP.Text = "Dot-Sphere Collision";
            this.DSP.UseVisualStyleBackColor = true;
            this.DSP.Click += new System.EventHandler(this.DSP_Click);
            // 
            // DRP
            // 
            this.DRP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DRP.Location = new System.Drawing.Point(12, 198);
            this.DRP.Name = "DRP";
            this.DRP.Size = new System.Drawing.Size(285, 25);
            this.DRP.TabIndex = 6;
            this.DRP.Text = "Dot-Rectangle Prism Collision";
            this.DRP.UseVisualStyleBackColor = true;
            this.DRP.Click += new System.EventHandler(this.DRP_Click);
            // 
            // DC
            // 
            this.DC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DC.Location = new System.Drawing.Point(12, 229);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(285, 25);
            this.DC.TabIndex = 7;
            this.DC.Text = "Dot-Cylinder Collision";
            this.DC.UseVisualStyleBackColor = true;
            this.DC.Click += new System.EventHandler(this.DC_Click);
            // 
            // CC
            // 
            this.CC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CC.Location = new System.Drawing.Point(12, 260);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(285, 25);
            this.CC.TabIndex = 8;
            this.CC.Text = "Cylinder-Cylinder Collision";
            this.CC.UseVisualStyleBackColor = true;
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // SPSP
            // 
            this.SPSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPSP.Location = new System.Drawing.Point(12, 291);
            this.SPSP.Name = "SPSP";
            this.SPSP.Size = new System.Drawing.Size(285, 25);
            this.SPSP.TabIndex = 9;
            this.SPSP.Text = "Sphere-Sphere Collision";
            this.SPSP.UseVisualStyleBackColor = true;
            this.SPSP.Click += new System.EventHandler(this.SPSP_Click);
            // 
            // SPC
            // 
            this.SPC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPC.Location = new System.Drawing.Point(12, 322);
            this.SPC.Name = "SPC";
            this.SPC.Size = new System.Drawing.Size(285, 25);
            this.SPC.TabIndex = 10;
            this.SPC.Text = "Sphere-Cylinder Collision";
            this.SPC.UseVisualStyleBackColor = true;
            this.SPC.Click += new System.EventHandler(this.SPC_Click);
            // 
            // SFSP
            // 
            this.SFSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SFSP.Location = new System.Drawing.Point(12, 353);
            this.SFSP.Name = "SFSP";
            this.SFSP.Size = new System.Drawing.Size(285, 25);
            this.SFSP.TabIndex = 11;
            this.SFSP.Text = "Surface-Sphere Collision";
            this.SFSP.UseVisualStyleBackColor = true;
            this.SFSP.Click += new System.EventHandler(this.SFSP_Click);
            // 
            // SFRP
            // 
            this.SFRP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SFRP.Location = new System.Drawing.Point(12, 384);
            this.SFRP.Name = "SFRP";
            this.SFRP.Size = new System.Drawing.Size(285, 25);
            this.SFRP.TabIndex = 12;
            this.SFRP.Text = "Surface-Rectangle Prism Collision";
            this.SFRP.UseVisualStyleBackColor = true;
            this.SFRP.Click += new System.EventHandler(this.SFRP_Click);
            // 
            // SFC
            // 
            this.SFC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SFC.Location = new System.Drawing.Point(12, 415);
            this.SFC.Name = "SFC";
            this.SFC.Size = new System.Drawing.Size(285, 25);
            this.SFC.TabIndex = 13;
            this.SFC.Text = "Surface-Cylinder Collision";
            this.SFC.UseVisualStyleBackColor = true;
            this.SFC.Click += new System.EventHandler(this.SFC_Click);
            // 
            // SPRP
            // 
            this.SPRP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPRP.Location = new System.Drawing.Point(12, 446);
            this.SPRP.Name = "SPRP";
            this.SPRP.Size = new System.Drawing.Size(285, 25);
            this.SPRP.TabIndex = 14;
            this.SPRP.Text = "Sphere-Rectangle Prism Collision";
            this.SPRP.UseVisualStyleBackColor = true;
            this.SPRP.Click += new System.EventHandler(this.SPRP_Click);
            // 
            // RPRP
            // 
            this.RPRP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RPRP.Location = new System.Drawing.Point(12, 477);
            this.RPRP.Name = "RPRP";
            this.RPRP.Size = new System.Drawing.Size(285, 25);
            this.RPRP.TabIndex = 15;
            this.RPRP.Text = "Rectangle Prism-Rectangle Prism Collision";
            this.RPRP.UseVisualStyleBackColor = true;
            this.RPRP.Click += new System.EventHandler(this.RPRP_Click);
            // 
            // controlChoice
            // 
            this.controlChoice.Location = new System.Drawing.Point(12, 508);
            this.controlChoice.Name = "controlChoice";
            this.controlChoice.Size = new System.Drawing.Size(120, 23);
            this.controlChoice.TabIndex = 16;
            this.controlChoice.Visible = false;
            // 
            // shape1X
            // 
            this.shape1X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1X.Location = new System.Drawing.Point(96, 15);
            this.shape1X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1X.Name = "shape1X";
            this.shape1X.Size = new System.Drawing.Size(90, 26);
            this.shape1X.TabIndex = 17;
            // 
            // pnlShape1
            // 
            this.pnlShape1.Controls.Add(this.He1);
            this.pnlShape1.Controls.Add(this.Dep1);
            this.pnlShape1.Controls.Add(this.Wid1);
            this.pnlShape1.Controls.Add(this.Rad1);
            this.pnlShape1.Controls.Add(this.Z1);
            this.pnlShape1.Controls.Add(this.Y1);
            this.pnlShape1.Controls.Add(this.X1);
            this.pnlShape1.Controls.Add(this.shape1He);
            this.pnlShape1.Controls.Add(this.shape1Dep);
            this.pnlShape1.Controls.Add(this.shape1Wid);
            this.pnlShape1.Controls.Add(this.shape1Rad);
            this.pnlShape1.Controls.Add(this.shape1Z);
            this.pnlShape1.Controls.Add(this.shape1Y);
            this.pnlShape1.Controls.Add(this.shape1X);
            this.pnlShape1.Location = new System.Drawing.Point(381, 51);
            this.pnlShape1.Name = "pnlShape1";
            this.pnlShape1.Size = new System.Drawing.Size(229, 286);
            this.pnlShape1.TabIndex = 18;
            // 
            // He1
            // 
            this.He1.AutoSize = true;
            this.He1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.He1.Location = new System.Drawing.Point(26, 202);
            this.He1.Name = "He1";
            this.He1.Size = new System.Drawing.Size(55, 19);
            this.He1.TabIndex = 29;
            this.He1.Text = "Height :";
            // 
            // Dep1
            // 
            this.Dep1.AutoSize = true;
            this.Dep1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dep1.Location = new System.Drawing.Point(27, 240);
            this.Dep1.Name = "Dep1";
            this.Dep1.Size = new System.Drawing.Size(53, 19);
            this.Dep1.TabIndex = 28;
            this.Dep1.Text = "Depth :";
            // 
            // Wid1
            // 
            this.Wid1.AutoSize = true;
            this.Wid1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wid1.Location = new System.Drawing.Point(29, 163);
            this.Wid1.Name = "Wid1";
            this.Wid1.Size = new System.Drawing.Size(52, 19);
            this.Wid1.TabIndex = 27;
            this.Wid1.Text = "Width :";
            // 
            // Rad1
            // 
            this.Rad1.AutoSize = true;
            this.Rad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rad1.Location = new System.Drawing.Point(24, 125);
            this.Rad1.Name = "Rad1";
            this.Rad1.Size = new System.Drawing.Size(57, 19);
            this.Rad1.TabIndex = 26;
            this.Rad1.Text = "Radius :";
            // 
            // Z1
            // 
            this.Z1.AutoSize = true;
            this.Z1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Z1.Location = new System.Drawing.Point(45, 89);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(25, 19);
            this.Z1.TabIndex = 25;
            this.Z1.Text = "Z :";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y1.Location = new System.Drawing.Point(45, 53);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(26, 19);
            this.Y1.TabIndex = 24;
            this.Y1.Text = "Y :";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X1.Location = new System.Drawing.Point(45, 18);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(27, 19);
            this.X1.TabIndex = 19;
            this.X1.Text = "X :";
            // 
            // shape1He
            // 
            this.shape1He.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1He.Location = new System.Drawing.Point(96, 200);
            this.shape1He.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1He.Name = "shape1He";
            this.shape1He.Size = new System.Drawing.Size(90, 26);
            this.shape1He.TabIndex = 23;
            // 
            // shape1Dep
            // 
            this.shape1Dep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1Dep.Location = new System.Drawing.Point(96, 238);
            this.shape1Dep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1Dep.Name = "shape1Dep";
            this.shape1Dep.Size = new System.Drawing.Size(90, 26);
            this.shape1Dep.TabIndex = 22;
            // 
            // shape1Wid
            // 
            this.shape1Wid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1Wid.Location = new System.Drawing.Point(96, 161);
            this.shape1Wid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1Wid.Name = "shape1Wid";
            this.shape1Wid.Size = new System.Drawing.Size(90, 26);
            this.shape1Wid.TabIndex = 21;
            // 
            // shape1Rad
            // 
            this.shape1Rad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1Rad.Location = new System.Drawing.Point(96, 123);
            this.shape1Rad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1Rad.Name = "shape1Rad";
            this.shape1Rad.Size = new System.Drawing.Size(90, 26);
            this.shape1Rad.TabIndex = 20;
            // 
            // shape1Z
            // 
            this.shape1Z.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1Z.Location = new System.Drawing.Point(96, 87);
            this.shape1Z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1Z.Name = "shape1Z";
            this.shape1Z.Size = new System.Drawing.Size(90, 26);
            this.shape1Z.TabIndex = 19;
            // 
            // shape1Y
            // 
            this.shape1Y.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape1Y.Location = new System.Drawing.Point(96, 51);
            this.shape1Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape1Y.Name = "shape1Y";
            this.shape1Y.Size = new System.Drawing.Size(90, 26);
            this.shape1Y.TabIndex = 18;
            // 
            // pnlShape2
            // 
            this.pnlShape2.Controls.Add(this.He2);
            this.pnlShape2.Controls.Add(this.Dep2);
            this.pnlShape2.Controls.Add(this.Wid2);
            this.pnlShape2.Controls.Add(this.Rad2);
            this.pnlShape2.Controls.Add(this.Z2);
            this.pnlShape2.Controls.Add(this.Y2);
            this.pnlShape2.Controls.Add(this.X2);
            this.pnlShape2.Controls.Add(this.shape2He);
            this.pnlShape2.Controls.Add(this.shape2Dep);
            this.pnlShape2.Controls.Add(this.shape2Wid);
            this.pnlShape2.Controls.Add(this.shape2Rad);
            this.pnlShape2.Controls.Add(this.shape2Z);
            this.pnlShape2.Controls.Add(this.shape2Y);
            this.pnlShape2.Controls.Add(this.shape2X);
            this.pnlShape2.Location = new System.Drawing.Point(839, 51);
            this.pnlShape2.Name = "pnlShape2";
            this.pnlShape2.Size = new System.Drawing.Size(229, 286);
            this.pnlShape2.TabIndex = 19;
            // 
            // He2
            // 
            this.He2.AutoSize = true;
            this.He2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.He2.Location = new System.Drawing.Point(28, 202);
            this.He2.Name = "He2";
            this.He2.Size = new System.Drawing.Size(55, 19);
            this.He2.TabIndex = 29;
            this.He2.Text = "Height :";
            // 
            // Dep2
            // 
            this.Dep2.AutoSize = true;
            this.Dep2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dep2.Location = new System.Drawing.Point(29, 240);
            this.Dep2.Name = "Dep2";
            this.Dep2.Size = new System.Drawing.Size(53, 19);
            this.Dep2.TabIndex = 28;
            this.Dep2.Text = "Depth :";
            // 
            // Wid2
            // 
            this.Wid2.AutoSize = true;
            this.Wid2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wid2.Location = new System.Drawing.Point(30, 163);
            this.Wid2.Name = "Wid2";
            this.Wid2.Size = new System.Drawing.Size(52, 19);
            this.Wid2.TabIndex = 27;
            this.Wid2.Text = "Width :";
            // 
            // Rad2
            // 
            this.Rad2.AutoSize = true;
            this.Rad2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rad2.Location = new System.Drawing.Point(25, 125);
            this.Rad2.Name = "Rad2";
            this.Rad2.Size = new System.Drawing.Size(57, 19);
            this.Rad2.TabIndex = 26;
            this.Rad2.Text = "Radius :";
            // 
            // Z2
            // 
            this.Z2.AutoSize = true;
            this.Z2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Z2.Location = new System.Drawing.Point(45, 89);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(25, 19);
            this.Z2.TabIndex = 25;
            this.Z2.Text = "Z :";
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y2.Location = new System.Drawing.Point(45, 53);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(26, 19);
            this.Y2.TabIndex = 24;
            this.Y2.Text = "Y :";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X2.Location = new System.Drawing.Point(45, 18);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(27, 19);
            this.X2.TabIndex = 19;
            this.X2.Text = "X :";
            // 
            // shape2He
            // 
            this.shape2He.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2He.Location = new System.Drawing.Point(96, 200);
            this.shape2He.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2He.Name = "shape2He";
            this.shape2He.Size = new System.Drawing.Size(90, 26);
            this.shape2He.TabIndex = 23;
            // 
            // shape2Dep
            // 
            this.shape2Dep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2Dep.Location = new System.Drawing.Point(96, 238);
            this.shape2Dep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2Dep.Name = "shape2Dep";
            this.shape2Dep.Size = new System.Drawing.Size(90, 26);
            this.shape2Dep.TabIndex = 22;
            // 
            // shape2Wid
            // 
            this.shape2Wid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2Wid.Location = new System.Drawing.Point(96, 161);
            this.shape2Wid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2Wid.Name = "shape2Wid";
            this.shape2Wid.Size = new System.Drawing.Size(90, 26);
            this.shape2Wid.TabIndex = 21;
            // 
            // shape2Rad
            // 
            this.shape2Rad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2Rad.Location = new System.Drawing.Point(96, 123);
            this.shape2Rad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2Rad.Name = "shape2Rad";
            this.shape2Rad.Size = new System.Drawing.Size(90, 26);
            this.shape2Rad.TabIndex = 20;
            // 
            // shape2Z
            // 
            this.shape2Z.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2Z.Location = new System.Drawing.Point(96, 87);
            this.shape2Z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2Z.Name = "shape2Z";
            this.shape2Z.Size = new System.Drawing.Size(90, 26);
            this.shape2Z.TabIndex = 19;
            // 
            // shape2Y
            // 
            this.shape2Y.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2Y.Location = new System.Drawing.Point(96, 51);
            this.shape2Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2Y.Name = "shape2Y";
            this.shape2Y.Size = new System.Drawing.Size(90, 26);
            this.shape2Y.TabIndex = 18;
            // 
            // shape2X
            // 
            this.shape2X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shape2X.Location = new System.Drawing.Point(96, 15);
            this.shape2X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shape2X.Name = "shape2X";
            this.shape2X.Size = new System.Drawing.Size(90, 26);
            this.shape2X.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(651, 159);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 33);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // collisionResult
            // 
            this.collisionResult.AutoSize = true;
            this.collisionResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collisionResult.Location = new System.Drawing.Point(651, 202);
            this.collisionResult.Name = "collisionResult";
            this.collisionResult.Size = new System.Drawing.Size(128, 21);
            this.collisionResult.TabIndex = 21;
            this.collisionResult.Text = "Collision Result";
            this.collisionResult.Visible = false;
            // 
            // drawShapes
            // 
            this.drawShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawShapes.Location = new System.Drawing.Point(426, 384);
            this.drawShapes.Name = "drawShapes";
            this.drawShapes.Size = new System.Drawing.Size(599, 347);
            this.drawShapes.TabIndex = 22;
            // 
            // pnl3dShape
            // 
            this.pnl3dShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3dShape.Location = new System.Drawing.Point(1107, 51);
            this.pnl3dShape.Name = "pnl3dShape";
            this.pnl3dShape.Size = new System.Drawing.Size(401, 286);
            this.pnl3dShape.TabIndex = 23;
            // 
            // firstShapeTag
            // 
            this.firstShapeTag.AutoSize = true;
            this.firstShapeTag.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstShapeTag.Location = new System.Drawing.Point(381, 14);
            this.firstShapeTag.Name = "firstShapeTag";
            this.firstShapeTag.Size = new System.Drawing.Size(114, 23);
            this.firstShapeTag.TabIndex = 24;
            this.firstShapeTag.Text = "First Shape :";
            // 
            // secondShapeTag
            // 
            this.secondShapeTag.AutoSize = true;
            this.secondShapeTag.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondShapeTag.Location = new System.Drawing.Point(837, 14);
            this.secondShapeTag.Name = "secondShapeTag";
            this.secondShapeTag.Size = new System.Drawing.Size(135, 23);
            this.secondShapeTag.TabIndex = 25;
            this.secondShapeTag.Text = "Second Shape :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 790);
            this.Controls.Add(this.secondShapeTag);
            this.Controls.Add(this.firstShapeTag);
            this.Controls.Add(this.pnl3dShape);
            this.Controls.Add(this.drawShapes);
            this.Controls.Add(this.collisionResult);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pnlShape2);
            this.Controls.Add(this.pnlShape1);
            this.Controls.Add(this.controlChoice);
            this.Controls.Add(this.RPRP);
            this.Controls.Add(this.SPRP);
            this.Controls.Add(this.SFC);
            this.Controls.Add(this.SFRP);
            this.Controls.Add(this.SFSP);
            this.Controls.Add(this.SPC);
            this.Controls.Add(this.SPSP);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.DRP);
            this.Controls.Add(this.DSP);
            this.Controls.Add(this.HH);
            this.Controls.Add(this.RH);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.DH);
            this.Controls.Add(this.DR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.controlChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1X)).EndInit();
            this.pnlShape1.ResumeLayout(false);
            this.pnlShape1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shape1He)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Wid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Rad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape1Y)).EndInit();
            this.pnlShape2.ResumeLayout(false);
            this.pnlShape2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shape2He)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Wid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Rad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape2X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DR;
        private Button DH;
        private Button RR;
        private Button RH;
        private Button HH;
        private Button DSP;
        private Button DRP;
        private Button DC;
        private Button CC;
        private Button SPSP;
        private Button SPC;
        private Button SFSP;
        private Button SFRP;
        private Button SFC;
        private Button SPRP;
        private Button RPRP;
        private NumericUpDown controlChoice;
        private NumericUpDown shape1X;
        private Panel pnlShape1;
        private Label He1;
        private Label Dep1;
        private Label Wid1;
        private Label Rad1;
        private Label Z1;
        private Label Y1;
        private Label X1;
        private NumericUpDown shape1He;
        private NumericUpDown shape1Dep;
        private NumericUpDown shape1Wid;
        private NumericUpDown shape1Rad;
        private NumericUpDown shape1Z;
        private NumericUpDown shape1Y;
        private Panel pnlShape2;
        private Label He2;
        private Label Dep2;
        private Label Wid2;
        private Label Rad2;
        private Label Z2;
        private Label Y2;
        private Label X2;
        private NumericUpDown shape2He;
        private NumericUpDown shape2Dep;
        private NumericUpDown shape2Wid;
        private NumericUpDown shape2Rad;
        private NumericUpDown shape2Z;
        private NumericUpDown shape2Y;
        private NumericUpDown shape2X;
        private Button calculateButton;
        private Label collisionResult;
        private Panel drawShapes;
        private Panel pnl3dShape;
        private Label firstShapeTag;
        private Label secondShapeTag;
    }
}