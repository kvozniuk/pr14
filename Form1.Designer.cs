namespace пр14
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
            pnlDisplay = new Panel();
            lblDisplay = new Label();
            tlpButtonsPanel = new TableLayoutPanel();
            btnCE = new Button();
            btnBackspace = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            pnlDisplay.SuspendLayout();
            tlpButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = SystemColors.Control;
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Dock = DockStyle.Top;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Padding = new Padding(5);
            pnlDisplay.Size = new Size(360, 80);
            pnlDisplay.TabIndex = 0;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = false;
            lblDisplay.BackColor = Color.White;
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDisplay.Location = new Point(5, 5);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(350, 70);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpButtonsPanel
            // 
            tlpButtonsPanel.ColumnCount = 4;
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.Controls.Add(btnCE, 0, 0);
            tlpButtonsPanel.Controls.Add(btnBackspace, 1, 0);
            tlpButtonsPanel.Controls.Add(btnPercent, 2, 0);
            tlpButtonsPanel.Controls.Add(btnDivide, 3, 0);
            tlpButtonsPanel.Controls.Add(btn7, 0, 1);
            tlpButtonsPanel.Controls.Add(btn8, 1, 1);
            tlpButtonsPanel.Controls.Add(btn9, 2, 1);
            tlpButtonsPanel.Controls.Add(btnMultiply, 3, 1);
            tlpButtonsPanel.Controls.Add(btn4, 0, 2);
            tlpButtonsPanel.Controls.Add(btn5, 1, 2);
            tlpButtonsPanel.Controls.Add(btn6, 2, 2);
            tlpButtonsPanel.Controls.Add(btnMinus, 3, 2);
            tlpButtonsPanel.Controls.Add(btn1, 0, 3);
            tlpButtonsPanel.Controls.Add(btn2, 1, 3);
            tlpButtonsPanel.Controls.Add(btn3, 2, 3);
            tlpButtonsPanel.Controls.Add(btnPlus, 3, 3);
            tlpButtonsPanel.Controls.Add(btn0, 0, 4);
            tlpButtonsPanel.Controls.Add(btnDecimal, 1, 4);
            tlpButtonsPanel.Controls.Add(btnEquals, 2, 4);
            tlpButtonsPanel.Dock = DockStyle.Fill;
            tlpButtonsPanel.Location = new Point(0, 80);
            tlpButtonsPanel.Name = "tlpButtonsPanel";
            tlpButtonsPanel.RowCount = 5;
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.Size = new Size(360, 320);
            tlpButtonsPanel.TabIndex = 1;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.Font = new Font("Segoe UI", 16F);
            btnCE.ForeColor = Color.OrangeRed;
            btnCE.Location = new Point(2, 2);
            btnCE.Margin = new Padding(2);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(86, 60);
            btnCE.TabIndex = 0;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += BtnCE_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI", 16F);
            btnBackspace.Location = new Point(92, 2);
            btnBackspace.Margin = new Padding(2);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(86, 60);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "←";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += BtnBackspace_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI", 16F);
            btnPercent.Location = new Point(182, 2);
            btnPercent.Margin = new Padding(2);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(86, 60);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += BtnPercent_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI", 16F);
            btnDivide.Location = new Point(272, 2);
            btnDivide.Margin = new Padding(2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(86, 60);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 16F);
            btn7.Location = new Point(2, 66);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(86, 60);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 16F);
            btn8.Location = new Point(92, 66);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(86, 60);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 16F);
            btn9.Location = new Point(182, 66);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(86, 60);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI", 16F);
            btnMultiply.Location = new Point(272, 66);
            btnMultiply.Margin = new Padding(2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(86, 60);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 16F);
            btn4.Location = new Point(2, 130);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(86, 60);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 16F);
            btn5.Location = new Point(92, 130);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(86, 60);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 16F);
            btn6.Location = new Point(182, 130);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(86, 60);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI", 16F);
            btnMinus.Location = new Point(272, 130);
            btnMinus.Margin = new Padding(2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(86, 60);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += BtnMinus_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 16F);
            btn1.Location = new Point(2, 194);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 60);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 16F);
            btn2.Location = new Point(92, 194);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(86, 60);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 16F);
            btn3.Location = new Point(182, 194);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(86, 60);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI", 16F);
            btnPlus.Location = new Point(272, 194);
            btnPlus.Margin = new Padding(2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(86, 60);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += BtnPlus_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 16F);
            btn0.Location = new Point(2, 258);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(86, 60);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Font = new Font("Segoe UI", 16F);
            btnDecimal.Location = new Point(92, 258);
            btnDecimal.Margin = new Padding(2);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(86, 60);
            btnDecimal.TabIndex = 17;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += NumberButton_Click;
            // 
            // btnEquals
            // 
            tlpButtonsPanel.SetColumnSpan(btnEquals, 2);
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Font = new Font("Segoe UI", 16F);
            btnEquals.Location = new Point(182, 258);
            btnEquals.Margin = new Padding(2);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(176, 60);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += BtnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 400);
            Controls.Add(tlpButtonsPanel);
            Controls.Add(pnlDisplay);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            pnlDisplay.ResumeLayout(false);
            tlpButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblDisplay;
        private TableLayoutPanel tlpButtonsPanel;
        private Button btnCE;
        private Button btnBackspace;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
    }
}
