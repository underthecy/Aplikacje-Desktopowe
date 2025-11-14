namespace homelogpro
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 0;
            label1.Text = "Login - Logowanie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(56, 50);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(258, 23);
            textBoxLogin.TabIndex = 2;
            textBoxLogin.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(56, 79);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(258, 23);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Hasło:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(56, 108);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Prześlij";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += button1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 159);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonSubmit;
    }
}