namespace пр14
{
    partial class ConfirmClearForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 11F);
            lblQuestion.Location = new Point(18, 18);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(344, 58);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Ви дійсно хочете очистити вміст калькулятора?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.DialogResult = DialogResult.Yes;
            buttonYes.Font = new Font("Segoe UI", 10F);
            buttonYes.Location = new Point(88, 92);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(90, 34);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Так";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += ButtonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.DialogResult = DialogResult.No;
            buttonNo.Font = new Font("Segoe UI", 10F);
            buttonNo.Location = new Point(202, 92);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(90, 34);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Ні";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += ButtonNo_Click;
            // 
            // ConfirmClearForm
            // 
            AcceptButton = buttonYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonNo;
            ClientSize = new Size(380, 148);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(lblQuestion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmClearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Підтвердження";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Button buttonYes;
        private Button buttonNo;
    }
}
