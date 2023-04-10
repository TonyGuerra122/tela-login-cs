namespace TesteLoginGUI {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            email = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            password = new TextBox();
            sendData = new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Location = new Point(193, 179);
            email.Name = "email";
            email.Size = new Size(341, 23);
            email.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 96);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(1, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 96);
            panel2.TabIndex = 2;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(193, 327);
            password.Name = "password";
            password.Size = new Size(341, 23);
            password.TabIndex = 3;
            // 
            // sendData
            // 
            sendData.Anchor = AnchorStyles.None;
            sendData.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            sendData.Location = new Point(271, 423);
            sendData.Name = "sendData";
            sendData.Size = new Size(177, 57);
            sendData.TabIndex = 4;
            sendData.Text = "Enviar";
            sendData.UseVisualStyleBackColor = true;
            sendData.Click += sendData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 580);
            Controls.Add(sendData);
            Controls.Add(password);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(email);
            MaximizeBox = false;
            MaximumSize = new Size(742, 619);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Panel panel1;
        private Panel panel2;
        private TextBox password;
        private Button sendData;
    }
}