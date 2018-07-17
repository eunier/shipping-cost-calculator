namespace WindowsFormsApp1
{
    partial class FrmCalculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdoBox = new System.Windows.Forms.RadioButton();
            this.rdoCarte = new System.Windows.Forms.RadioButton();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCentimeter = new System.Windows.Forms.RadioButton();
            this.rdoInch = new System.Windows.Forms.RadioButton();
            this.grbDimentionsImput = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtOriging = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResultsBar = new System.Windows.Forms.Label();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoKilogram = new System.Windows.Forms.RadioButton();
            this.rdoPound = new System.Windows.Forms.RadioButton();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbDimentionsImput.SuspendLayout();
            this.grbResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(254, 57);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SHIPPING CALCULATOR";
            // 
            // rdoBox
            // 
            this.rdoBox.AutoSize = true;
            this.rdoBox.Location = new System.Drawing.Point(146, 31);
            this.rdoBox.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBox.Name = "rdoBox";
            this.rdoBox.Size = new System.Drawing.Size(52, 23);
            this.rdoBox.TabIndex = 3;
            this.rdoBox.TabStop = true;
            this.rdoBox.Text = "Box";
            this.rdoBox.UseVisualStyleBackColor = true;
            this.rdoBox.CheckedChanged += new System.EventHandler(this.rdoBox_CheckedChanged);
            // 
            // rdoCarte
            // 
            this.rdoCarte.AutoSize = true;
            this.rdoCarte.Location = new System.Drawing.Point(146, 74);
            this.rdoCarte.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCarte.Name = "rdoCarte";
            this.rdoCarte.Size = new System.Drawing.Size(61, 23);
            this.rdoCarte.TabIndex = 4;
            this.rdoCarte.TabStop = true;
            this.rdoCarte.Text = "Crate";
            this.rdoCarte.UseVisualStyleBackColor = true;
            this.rdoCarte.CheckedChanged += new System.EventHandler(this.rdoCarte_CheckedChanged);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.picBox);
            this.grpType.Controls.Add(this.rdoOther);
            this.grpType.Controls.Add(this.rdoBox);
            this.grpType.Controls.Add(this.rdoCarte);
            this.grpType.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(20, 186);
            this.grpType.Margin = new System.Windows.Forms.Padding(2);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(2);
            this.grpType.Size = new System.Drawing.Size(256, 170);
            this.grpType.TabIndex = 5;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // picBox
            // 
            this.picBox.Image = global::WindowsFormsApp1.Properties.Resources.cardboard;
            this.picBox.Location = new System.Drawing.Point(4, 17);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(120, 136);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(146, 116);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(2);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(64, 23);
            this.rdoOther.TabIndex = 5;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCentimeter);
            this.groupBox1.Controls.Add(this.rdoInch);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(191, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimentions Units";
            // 
            // rdoCentimeter
            // 
            this.rdoCentimeter.AutoSize = true;
            this.rdoCentimeter.Location = new System.Drawing.Point(25, 58);
            this.rdoCentimeter.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCentimeter.Name = "rdoCentimeter";
            this.rdoCentimeter.Size = new System.Drawing.Size(96, 23);
            this.rdoCentimeter.TabIndex = 2;
            this.rdoCentimeter.TabStop = true;
            this.rdoCentimeter.Text = "Centimeter";
            this.rdoCentimeter.UseVisualStyleBackColor = true;
            this.rdoCentimeter.CheckedChanged += new System.EventHandler(this.rdoCentimeter_CheckedChanged);
            // 
            // rdoInch
            // 
            this.rdoInch.AutoSize = true;
            this.rdoInch.Location = new System.Drawing.Point(25, 102);
            this.rdoInch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoInch.Name = "rdoInch";
            this.rdoInch.Size = new System.Drawing.Size(56, 23);
            this.rdoInch.TabIndex = 1;
            this.rdoInch.TabStop = true;
            this.rdoInch.Text = "Inch";
            this.rdoInch.UseVisualStyleBackColor = true;
            this.rdoInch.CheckedChanged += new System.EventHandler(this.rdoInch_CheckedChanged);
            // 
            // grbDimentionsImput
            // 
            this.grbDimentionsImput.Controls.Add(this.txtHeight);
            this.grbDimentionsImput.Controls.Add(this.txtTotalWeight);
            this.grbDimentionsImput.Controls.Add(this.txtWidth);
            this.grbDimentionsImput.Controls.Add(this.txtLenght);
            this.grbDimentionsImput.Location = new System.Drawing.Point(736, 186);
            this.grbDimentionsImput.Margin = new System.Windows.Forms.Padding(2);
            this.grbDimentionsImput.Name = "grbDimentionsImput";
            this.grbDimentionsImput.Padding = new System.Windows.Forms.Padding(2);
            this.grbDimentionsImput.Size = new System.Drawing.Size(150, 169);
            this.grbDimentionsImput.TabIndex = 7;
            this.grbDimentionsImput.TabStop = false;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHeight.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHeight.Location = new System.Drawing.Point(26, 81);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(93, 29);
            this.txtHeight.TabIndex = 13;
            this.txtHeight.Text = "Height";
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalWeight.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWeight.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalWeight.Location = new System.Drawing.Point(26, 115);
            this.txtTotalWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalWeight.Multiline = true;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(93, 29);
            this.txtTotalWeight.TabIndex = 12;
            this.txtTotalWeight.Text = "Total Weight";
            this.txtTotalWeight.Enter += new System.EventHandler(this.txtTotalWeight_Enter);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWidth.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWidth.Location = new System.Drawing.Point(26, 48);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(93, 29);
            this.txtWidth.TabIndex = 11;
            this.txtWidth.Text = "Width";
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            // 
            // txtLenght
            // 
            this.txtLenght.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLenght.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLenght.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLenght.Location = new System.Drawing.Point(26, 15);
            this.txtLenght.Margin = new System.Windows.Forms.Padding(2);
            this.txtLenght.Multiline = true;
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(93, 29);
            this.txtLenght.TabIndex = 10;
            this.txtLenght.Text = "Lenght";
            this.txtLenght.TextChanged += new System.EventHandler(this.txtLenght_TextChanged);
            this.txtLenght.Enter += new System.EventHandler(this.txtLenght_Enter);
            // 
            // txtOriging
            // 
            this.txtOriging.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOriging.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOriging.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOriging.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriging.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOriging.Location = new System.Drawing.Point(20, 97);
            this.txtOriging.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriging.Name = "txtOriging";
            this.txtOriging.Size = new System.Drawing.Size(681, 26);
            this.txtOriging.TabIndex = 8;
            this.txtOriging.Text = "Origin";
            this.txtOriging.Enter += new System.EventHandler(this.txtOriging_Enter);
            // 
            // txtDest
            // 
            this.txtDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDest.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDest.Location = new System.Drawing.Point(20, 133);
            this.txtDest.Margin = new System.Windows.Forms.Padding(2);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(681, 26);
            this.txtDest.TabIndex = 9;
            this.txtDest.Text = "Destination";
            this.txtDest.Enter += new System.EventHandler(this.txtDest_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Navy;
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(736, 372);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 34);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Shipping";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResultsBar
            // 
            this.lblResultsBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultsBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultsBar.Location = new System.Drawing.Point(14, 27);
            this.lblResultsBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultsBar.Name = "lblResultsBar";
            this.lblResultsBar.Size = new System.Drawing.Size(621, 24);
            this.lblResultsBar.TabIndex = 11;
            this.lblResultsBar.Text = "PACKAGE TYPE             LENGTH              WIDTH                  HEIGHT       " +
    "           WEIGHT                 ";
            // 
            // grbResults
            // 
            this.grbResults.Controls.Add(this.lblHeight);
            this.grbResults.Controls.Add(this.lblWidth);
            this.grbResults.Controls.Add(this.lblLength);
            this.grbResults.Controls.Add(this.lblWeight);
            this.grbResults.Controls.Add(this.lblType);
            this.grbResults.Controls.Add(this.lblResultsBar);
            this.grbResults.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResults.Location = new System.Drawing.Point(10, 372);
            this.grbResults.Margin = new System.Windows.Forms.Padding(2);
            this.grbResults.Name = "grbResults";
            this.grbResults.Padding = new System.Windows.Forms.Padding(2);
            this.grbResults.Size = new System.Drawing.Size(722, 111);
            this.grbResults.TabIndex = 12;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Shipping Calculation Results";
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeight.Location = new System.Drawing.Point(389, 51);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(121, 25);
            this.lblHeight.TabIndex = 16;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWidth.Location = new System.Drawing.Point(264, 51);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(121, 25);
            this.lblWidth.TabIndex = 15;
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.Color.AliceBlue;
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLength.Location = new System.Drawing.Point(139, 51);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(121, 25);
            this.lblLength.TabIndex = 14;
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWeight.Location = new System.Drawing.Point(514, 51);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(121, 25);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.AliceBlue;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblType.Location = new System.Drawing.Point(14, 51);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 25);
            this.lblType.TabIndex = 12;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Location = new System.Drawing.Point(736, 410);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Clear Results";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(736, 449);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDistance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDistance.Location = new System.Drawing.Point(736, 116);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(105, 32);
            this.lblDistance.TabIndex = 17;
            this.lblDistance.Click += new System.EventHandler(this.lblDistance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoKilogram);
            this.groupBox2.Controls.Add(this.rdoPound);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(475, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(257, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight Units";
            // 
            // rdoKilogram
            // 
            this.rdoKilogram.AutoSize = true;
            this.rdoKilogram.Location = new System.Drawing.Point(23, 102);
            this.rdoKilogram.Margin = new System.Windows.Forms.Padding(2);
            this.rdoKilogram.Name = "rdoKilogram";
            this.rdoKilogram.Size = new System.Drawing.Size(86, 23);
            this.rdoKilogram.TabIndex = 3;
            this.rdoKilogram.TabStop = true;
            this.rdoKilogram.Text = "Kilogram";
            this.rdoKilogram.UseVisualStyleBackColor = true;
            // 
            // rdoPound
            // 
            this.rdoPound.AutoSize = true;
            this.rdoPound.Location = new System.Drawing.Point(23, 58);
            this.rdoPound.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPound.Name = "rdoPound";
            this.rdoPound.Size = new System.Drawing.Size(70, 23);
            this.rdoPound.TabIndex = 0;
            this.rdoPound.TabStop = true;
            this.rdoPound.Text = "Pound";
            this.rdoPound.UseVisualStyleBackColor = true;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtOriging);
            this.Controls.Add(this.grbDimentionsImput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDimentionsImput.ResumeLayout(false);
            this.grbDimentionsImput.PerformLayout();
            this.grbResults.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdoBox;
        private System.Windows.Forms.RadioButton rdoCarte;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCentimeter;
        private System.Windows.Forms.RadioButton rdoInch;
        private System.Windows.Forms.GroupBox grbDimentionsImput;
        private System.Windows.Forms.TextBox txtOriging;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResultsBar;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoKilogram;
        private System.Windows.Forms.RadioButton rdoPound;
    }
}

