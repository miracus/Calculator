namespace git_cbs_lesson03_ex06_calculator
{
    partial class Main
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
            bComma = new Button();
            b0 = new Button();
            bSighInverse = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            b5 = new Button();
            b4 = new Button();
            b8 = new Button();
            b7 = new Button();
            bPow2 = new Button();
            bOneDivX = new Button();
            bCE = new Button();
            bPercent = new Button();
            cBackSpace = new Button();
            bDiv = new Button();
            bMul = new Button();
            bSub = new Button();
            bAdd = new Button();
            bResult = new Button();
            labelField2 = new Label();
            labelField1 = new Label();
            tlpButtons = new TableLayoutPanel();
            bC = new Button();
            bSqrt2 = new Button();
            b9 = new Button();
            b6 = new Button();
            tlpLabel = new TableLayoutPanel();
            tlpButtons.SuspendLayout();
            tlpLabel.SuspendLayout();
            SuspendLayout();
            // 
            // bComma
            // 
            bComma.Dock = DockStyle.Fill;
            bComma.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bComma.Location = new Point(207, 296);
            bComma.Margin = new Padding(1);
            bComma.Name = "bComma";
            bComma.Size = new Size(101, 61);
            bComma.TabIndex = 23;
            bComma.Text = ",";
            bComma.UseVisualStyleBackColor = true;
            // 
            // b0
            // 
            b0.Dock = DockStyle.Fill;
            b0.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b0.Location = new Point(104, 296);
            b0.Margin = new Padding(1);
            b0.Name = "b0";
            b0.Size = new Size(101, 61);
            b0.TabIndex = 22;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.MouseClick += bNumber_Click;
            // 
            // bSighInverse
            // 
            bSighInverse.Dock = DockStyle.Fill;
            bSighInverse.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bSighInverse.Location = new Point(1, 296);
            bSighInverse.Margin = new Padding(1);
            bSighInverse.Name = "bSighInverse";
            bSighInverse.Size = new Size(101, 61);
            bSighInverse.TabIndex = 21;
            bSighInverse.Text = "+/-";
            bSighInverse.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Dock = DockStyle.Fill;
            b3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b3.Location = new Point(207, 237);
            b3.Margin = new Padding(1);
            b3.Name = "b3";
            b3.Size = new Size(101, 57);
            b3.TabIndex = 20;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.MouseClick += bNumber_Click;
            // 
            // b2
            // 
            b2.Dock = DockStyle.Fill;
            b2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b2.Location = new Point(104, 237);
            b2.Margin = new Padding(1);
            b2.Name = "b2";
            b2.Size = new Size(101, 57);
            b2.TabIndex = 19;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.MouseClick += bNumber_Click;
            // 
            // b1
            // 
            b1.Dock = DockStyle.Fill;
            b1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b1.Location = new Point(1, 237);
            b1.Margin = new Padding(1);
            b1.Name = "b1";
            b1.Size = new Size(101, 57);
            b1.TabIndex = 18;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.MouseClick += bNumber_Click;
            // 
            // b5
            // 
            b5.Dock = DockStyle.Fill;
            b5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b5.Location = new Point(104, 178);
            b5.Margin = new Padding(1);
            b5.Name = "b5";
            b5.Size = new Size(101, 57);
            b5.TabIndex = 17;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.MouseClick += bNumber_Click;
            // 
            // b4
            // 
            b4.Dock = DockStyle.Fill;
            b4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b4.Location = new Point(1, 178);
            b4.Margin = new Padding(1);
            b4.Name = "b4";
            b4.Size = new Size(101, 57);
            b4.TabIndex = 16;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.MouseClick += bNumber_Click;
            // 
            // b8
            // 
            b8.Dock = DockStyle.Fill;
            b8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b8.Location = new Point(104, 119);
            b8.Margin = new Padding(1);
            b8.Name = "b8";
            b8.Size = new Size(101, 57);
            b8.TabIndex = 15;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.MouseClick += bNumber_Click;
            // 
            // b7
            // 
            b7.Dock = DockStyle.Fill;
            b7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b7.Location = new Point(1, 119);
            b7.Margin = new Padding(1);
            b7.Name = "b7";
            b7.Size = new Size(101, 57);
            b7.TabIndex = 14;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.MouseClick += bNumber_Click;
            // 
            // bPow2
            // 
            bPow2.Dock = DockStyle.Fill;
            bPow2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bPow2.Location = new Point(104, 60);
            bPow2.Margin = new Padding(1);
            bPow2.Name = "bPow2";
            bPow2.Size = new Size(101, 57);
            bPow2.TabIndex = 13;
            bPow2.Text = "x²";
            bPow2.UseVisualStyleBackColor = true;
            // 
            // bOneDivX
            // 
            bOneDivX.Dock = DockStyle.Fill;
            bOneDivX.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bOneDivX.Location = new Point(1, 60);
            bOneDivX.Margin = new Padding(1);
            bOneDivX.Name = "bOneDivX";
            bOneDivX.Size = new Size(101, 57);
            bOneDivX.TabIndex = 12;
            bOneDivX.Text = "1/x";
            bOneDivX.UseVisualStyleBackColor = true;
            // 
            // bCE
            // 
            bCE.Dock = DockStyle.Fill;
            bCE.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bCE.Location = new Point(104, 1);
            bCE.Margin = new Padding(1);
            bCE.Name = "bCE";
            bCE.Size = new Size(101, 57);
            bCE.TabIndex = 11;
            bCE.Text = "CE";
            bCE.UseVisualStyleBackColor = true;
            bCE.MouseClick += bCE_Click;
            // 
            // bPercent
            // 
            bPercent.Dock = DockStyle.Fill;
            bPercent.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bPercent.Location = new Point(1, 1);
            bPercent.Margin = new Padding(1);
            bPercent.Name = "bPercent";
            bPercent.Size = new Size(101, 57);
            bPercent.TabIndex = 10;
            bPercent.Text = "%";
            bPercent.UseVisualStyleBackColor = true;
            // 
            // cBackSpace
            // 
            cBackSpace.Dock = DockStyle.Fill;
            cBackSpace.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBackSpace.Location = new Point(310, 1);
            cBackSpace.Margin = new Padding(1);
            cBackSpace.Name = "cBackSpace";
            cBackSpace.Size = new Size(102, 57);
            cBackSpace.TabIndex = 0;
            cBackSpace.Text = "del";
            cBackSpace.UseVisualStyleBackColor = true;
            // 
            // bDiv
            // 
            bDiv.Dock = DockStyle.Fill;
            bDiv.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bDiv.Location = new Point(310, 60);
            bDiv.Margin = new Padding(1);
            bDiv.Name = "bDiv";
            bDiv.Size = new Size(102, 57);
            bDiv.TabIndex = 1;
            bDiv.Text = "/";
            bDiv.UseVisualStyleBackColor = true;
            // 
            // bMul
            // 
            bMul.Dock = DockStyle.Fill;
            bMul.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bMul.Location = new Point(310, 119);
            bMul.Margin = new Padding(1);
            bMul.Name = "bMul";
            bMul.Size = new Size(102, 57);
            bMul.TabIndex = 2;
            bMul.Text = "*";
            bMul.UseVisualStyleBackColor = true;
            // 
            // bSub
            // 
            bSub.Dock = DockStyle.Fill;
            bSub.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bSub.Location = new Point(310, 178);
            bSub.Margin = new Padding(1);
            bSub.Name = "bSub";
            bSub.Size = new Size(102, 57);
            bSub.TabIndex = 3;
            bSub.Text = "-";
            bSub.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            bAdd.Dock = DockStyle.Fill;
            bAdd.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAdd.Location = new Point(310, 237);
            bAdd.Margin = new Padding(1);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(102, 57);
            bAdd.TabIndex = 4;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // bResult
            // 
            bResult.Dock = DockStyle.Fill;
            bResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bResult.ForeColor = SystemColors.ActiveCaptionText;
            bResult.Location = new Point(310, 296);
            bResult.Margin = new Padding(1);
            bResult.Name = "bResult";
            bResult.Size = new Size(102, 61);
            bResult.TabIndex = 5;
            bResult.Text = "=";
            bResult.UseVisualStyleBackColor = true;
            // 
            // labelField2
            // 
            labelField2.AutoSize = true;
            labelField2.Dock = DockStyle.Fill;
            labelField2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelField2.Location = new Point(3, 63);
            labelField2.Name = "labelField2";
            labelField2.Size = new Size(413, 75);
            labelField2.TabIndex = 0;
            labelField2.Text = "labelField2";
            labelField2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelField1
            // 
            labelField1.AutoSize = true;
            labelField1.Dock = DockStyle.Fill;
            labelField1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelField1.Location = new Point(3, 0);
            labelField1.Name = "labelField1";
            labelField1.Size = new Size(413, 63);
            labelField1.TabIndex = 1;
            labelField1.Text = "labelField1";
            labelField1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 4;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.Controls.Add(bComma, 2, 5);
            tlpButtons.Controls.Add(b0, 1, 5);
            tlpButtons.Controls.Add(bSighInverse, 0, 5);
            tlpButtons.Controls.Add(b3, 2, 4);
            tlpButtons.Controls.Add(b2, 1, 4);
            tlpButtons.Controls.Add(b1, 0, 4);
            tlpButtons.Controls.Add(b5, 1, 3);
            tlpButtons.Controls.Add(b4, 0, 3);
            tlpButtons.Controls.Add(b8, 1, 2);
            tlpButtons.Controls.Add(b7, 0, 2);
            tlpButtons.Controls.Add(bPow2, 1, 1);
            tlpButtons.Controls.Add(bOneDivX, 0, 1);
            tlpButtons.Controls.Add(bCE, 1, 0);
            tlpButtons.Controls.Add(bPercent, 0, 0);
            tlpButtons.Controls.Add(cBackSpace, 3, 0);
            tlpButtons.Controls.Add(bDiv, 3, 1);
            tlpButtons.Controls.Add(bMul, 3, 2);
            tlpButtons.Controls.Add(bSub, 3, 3);
            tlpButtons.Controls.Add(bAdd, 3, 4);
            tlpButtons.Controls.Add(bResult, 3, 5);
            tlpButtons.Controls.Add(bC, 2, 0);
            tlpButtons.Controls.Add(bSqrt2, 2, 1);
            tlpButtons.Controls.Add(b9, 2, 2);
            tlpButtons.Controls.Add(b6, 2, 3);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.Location = new Point(3, 141);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 6;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpButtons.Size = new Size(413, 358);
            tlpButtons.TabIndex = 2;
            // 
            // bC
            // 
            bC.Dock = DockStyle.Fill;
            bC.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bC.Location = new Point(207, 1);
            bC.Margin = new Padding(1);
            bC.Name = "bC";
            bC.Size = new Size(101, 57);
            bC.TabIndex = 6;
            bC.Text = "C";
            bC.UseVisualStyleBackColor = true;
            bC.MouseClick += bC_Click;
            // 
            // bSqrt2
            // 
            bSqrt2.Dock = DockStyle.Fill;
            bSqrt2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bSqrt2.Location = new Point(207, 60);
            bSqrt2.Margin = new Padding(1);
            bSqrt2.Name = "bSqrt2";
            bSqrt2.Size = new Size(101, 57);
            bSqrt2.TabIndex = 7;
            bSqrt2.Text = "²√x";
            bSqrt2.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            b9.Dock = DockStyle.Fill;
            b9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b9.Location = new Point(207, 119);
            b9.Margin = new Padding(1);
            b9.Name = "b9";
            b9.Size = new Size(101, 57);
            b9.TabIndex = 8;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.MouseClick += bNumber_Click;
            // 
            // b6
            // 
            b6.Dock = DockStyle.Fill;
            b6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            b6.Location = new Point(207, 178);
            b6.Margin = new Padding(1);
            b6.Name = "b6";
            b6.Size = new Size(101, 57);
            b6.TabIndex = 9;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.MouseClick += bNumber_Click;
            // 
            // tlpLabel
            // 
            tlpLabel.ColumnCount = 1;
            tlpLabel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLabel.Controls.Add(labelField2, 0, 1);
            tlpLabel.Controls.Add(labelField1, 0, 0);
            tlpLabel.Controls.Add(tlpButtons, 0, 2);
            tlpLabel.Dock = DockStyle.Fill;
            tlpLabel.Location = new Point(0, 0);
            tlpLabel.Name = "tlpLabel";
            tlpLabel.RowCount = 3;
            tlpLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.0122681F));
            tlpLabel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.9877319F));
            tlpLabel.RowStyles.Add(new RowStyle(SizeType.Absolute, 363F));
            tlpLabel.Size = new Size(419, 502);
            tlpLabel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 502);
            Controls.Add(tlpLabel);
            Name = "Main";
            Text = "Calculator";
            KeyDown += Main_KeyDown;
            KeyPress += Main_KeyPress;
            KeyUp += Main_KeyUp;
            tlpButtons.ResumeLayout(false);
            tlpLabel.ResumeLayout(false);
            tlpLabel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bComma;
        private Button b0;
        private Button bSighInverse;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button b5;
        private Button b4;
        private Button b8;
        private Button b7;
        private Button bPow2;
        private Button bOneDivX;
        private Button bCE;
        private Button bPercent;
        private Button cBackSpace;
        private Button bDiv;
        private Button bMul;
        private Button bSub;
        private Button bAdd;
        private Button bResult;
        private Label labelField2;
        private Label labelField1;
        private TableLayoutPanel tlpButtons;
        private Button bC;
        private Button bSqrt2;
        private Button b9;
        private Button b6;
        private TableLayoutPanel tlpLabel;
    }
}