namespace CS311_Project2_ABE
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
            lblDice1 = new Label();
            lblDice2 = new Label();
            lblBankBalance = new Label();
            lblBet = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblOutcome = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.BackColor = SystemColors.ControlDark;
            lblDice1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice1.Location = new Point(735, 262);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(75, 71);
            lblDice1.TabIndex = 0;
            lblDice1.Text = "   ";
            lblDice1.TextAlign = ContentAlignment.MiddleRight;
            lblDice1.Click += label1_Click;
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.BackColor = SystemColors.ControlDark;
            lblDice2.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice2.Location = new Point(900, 262);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(75, 71);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "   ";
            lblDice2.TextAlign = ContentAlignment.MiddleRight;
            lblDice2.Click += label1_Click_1;
            // 
            // lblBankBalance
            // 
            lblBankBalance.AutoSize = true;
            lblBankBalance.Location = new Point(306, 213);
            lblBankBalance.Name = "lblBankBalance";
            lblBankBalance.Size = new Size(97, 32);
            lblBankBalance.TabIndex = 4;
            lblBankBalance.Text = "$100.00";
            lblBankBalance.Click += label1_Click_2;
            // 
            // lblBet
            // 
            lblBet.AutoSize = true;
            lblBet.Location = new Point(229, 301);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(54, 32);
            lblBet.TabIndex = 6;
            lblBet.Text = "Bet:";
            lblBet.Click += label1_Click_3;
            // 
            // txtBet
            // 
            txtBet.Location = new Point(306, 298);
            txtBet.Name = "txtBet";
            txtBet.Size = new Size(200, 39);
            txtBet.TabIndex = 7;
            txtBet.Text = "Enter your bet";
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(287, 388);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(219, 138);
            btnRoll.TabIndex = 8;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Location = new Point(746, 484);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(118, 32);
            lblOutcome.TabIndex = 9;
            lblOutcome.Text = "Outcome:";
            lblOutcome.Click += label1_Click_4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 213);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 10;
            label1.Text = "Bank Balance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 723);
            Controls.Add(label1);
            Controls.Add(lblOutcome);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBet);
            Controls.Add(lblBankBalance);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            Name = "Form1";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBankBalance;
        private Label lblBet;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutcome;
        private Label label1;
    }
}