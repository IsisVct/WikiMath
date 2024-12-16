namespace ProjetoCGTEC2023
{
    partial class frmCirculoTrigonometrico
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
            this.pboxCircle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCosine = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSine = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTangent = new System.Windows.Forms.NumericUpDown();
            this.numCotangent = new System.Windows.Forms.NumericUpDown();
            this.numArcLength = new System.Windows.Forms.NumericUpDown();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCosecant = new System.Windows.Forms.NumericUpDown();
            this.numSecant = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTangent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCotangent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArcLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosecant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecant)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxCircle
            // 
            this.pboxCircle.BackColor = System.Drawing.Color.Transparent;
            this.pboxCircle.Location = new System.Drawing.Point(411, 48);
            this.pboxCircle.Margin = new System.Windows.Forms.Padding(0);
            this.pboxCircle.Name = "pboxCircle";
            this.pboxCircle.Size = new System.Drawing.Size(330, 305);
            this.pboxCircle.TabIndex = 0;
            this.pboxCircle.TabStop = false;
            this.pboxCircle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pboxCircle_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ângulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arco";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(307, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cosseno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numCosine
            // 
            this.numCosine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCosine.DecimalPlaces = 2;
            this.numCosine.ForeColor = System.Drawing.Color.RoyalBlue;
            this.numCosine.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCosine.Location = new System.Drawing.Point(378, 134);
            this.numCosine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCosine.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCosine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numCosine.Name = "numCosine";
            this.numCosine.Size = new System.Drawing.Size(116, 24);
            this.numCosine.TabIndex = 7;
            this.numCosine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCosine.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numCosine.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(307, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seno";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numSine
            // 
            this.numSine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSine.DecimalPlaces = 2;
            this.numSine.ForeColor = System.Drawing.Color.Firebrick;
            this.numSine.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSine.Location = new System.Drawing.Point(378, 53);
            this.numSine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSine.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSine.Name = "numSine";
            this.numSine.Size = new System.Drawing.Size(116, 24);
            this.numSine.TabIndex = 5;
            this.numSine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSine.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numSine.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(619, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cotangente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(619, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tangente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTangent
            // 
            this.numTangent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTangent.DecimalPlaces = 2;
            this.numTangent.ForeColor = System.Drawing.Color.Olive;
            this.numTangent.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numTangent.Location = new System.Drawing.Point(706, 53);
            this.numTangent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTangent.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTangent.Name = "numTangent";
            this.numTangent.Size = new System.Drawing.Size(116, 24);
            this.numTangent.TabIndex = 9;
            this.numTangent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTangent.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numTangent.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // numCotangent
            // 
            this.numCotangent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCotangent.DecimalPlaces = 2;
            this.numCotangent.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.numCotangent.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCotangent.Location = new System.Drawing.Point(706, 134);
            this.numCotangent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCotangent.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCotangent.Name = "numCotangent";
            this.numCotangent.Size = new System.Drawing.Size(116, 24);
            this.numCotangent.TabIndex = 11;
            this.numCotangent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCotangent.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numCotangent.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // numArcLength
            // 
            this.numArcLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numArcLength.DecimalPlaces = 2;
            this.numArcLength.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numArcLength.Location = new System.Drawing.Point(66, 134);
            this.numArcLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numArcLength.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numArcLength.Name = "numArcLength";
            this.numArcLength.Size = new System.Drawing.Size(116, 24);
            this.numArcLength.TabIndex = 3;
            this.numArcLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numArcLength.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numArcLength.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // numAngle
            // 
            this.numAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAngle.DecimalPlaces = 2;
            this.numAngle.Location = new System.Drawing.Point(66, 53);
            this.numAngle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(116, 24);
            this.numAngle.TabIndex = 1;
            this.numAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numAngle.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numAngle.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(947, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Secante";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(947, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cossecante";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numCosecant
            // 
            this.numCosecant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCosecant.DecimalPlaces = 2;
            this.numCosecant.ForeColor = System.Drawing.Color.DarkViolet;
            this.numCosecant.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCosecant.Location = new System.Drawing.Point(1035, 134);
            this.numCosecant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCosecant.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCosecant.Name = "numCosecant";
            this.numCosecant.Size = new System.Drawing.Size(125, 24);
            this.numCosecant.TabIndex = 15;
            this.numCosecant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCosecant.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numCosecant.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // numSecant
            // 
            this.numSecant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSecant.DecimalPlaces = 2;
            this.numSecant.ForeColor = System.Drawing.Color.ForestGreen;
            this.numSecant.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSecant.Location = new System.Drawing.Point(1035, 53);
            this.numSecant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSecant.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSecant.Name = "numSecant";
            this.numSecant.Size = new System.Drawing.Size(125, 24);
            this.numSecant.TabIndex = 13;
            this.numSecant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSecant.ValueChanged += new System.EventHandler(this.numerics_ValueChanged);
            this.numSecant.Enter += new System.EventHandler(this.numerics_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.numCosecant, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numSecant, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.numAngle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.numArcLength, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numCotangent, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.numTangent, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.numSine, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.numCosine, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 393);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 213);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(381, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Círculo Trigonométrico";
            // 
            // frmTrigonometricCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pboxCircle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrigonometricCircle";
            this.Text = "Círculo Trigonométrico";
            this.Load += new System.EventHandler(this.frmTrigonometricCircle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTangent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCotangent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArcLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosecant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecant)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCosine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.NumericUpDown numArcLength;
        private System.Windows.Forms.NumericUpDown numCotangent;
        private System.Windows.Forms.NumericUpDown numTangent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCosecant;
        private System.Windows.Forms.NumericUpDown numSecant;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
    }
}