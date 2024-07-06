namespace LoginScreen
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
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            button1 = new Button();
            password = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 46);
            label1.Name = "label1";
            label1.Size = new Size(186, 33);
            label1.TabIndex = 0;
            label1.Text = "Enter username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(346, 155);
            label2.Name = "label2";
            label2.Size = new Size(188, 33);
            label2.TabIndex = 1;
            label2.Text = "Enter Password";
            label2.Click += label2_Click;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(348, 98);
            username.Name = "username";
            username.Size = new Size(309, 41);
            username.TabIndex = 2;
            username.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 284);
            button1.Name = "button1";
            button1.Size = new Size(309, 53);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15F);
            password.Location = new Point(346, 205);
            password.Name = "password";
            password.Size = new Size(307, 41);
            password.TabIndex = 5;
            password.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 514);
            Controls.Add(password);
            Controls.Add(button1);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private Button button1;
        private MaskedTextBox password;
    }
}
