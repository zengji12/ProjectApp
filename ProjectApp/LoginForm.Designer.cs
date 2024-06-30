namespace ProjectApp
{
	partial class LoginForm
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
			loginButton = new Button();
			label2 = new Label();
			usernameTxt = new TextBox();
			passwordTxt = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F);
			label1.Location = new Point(213, 120);
			label1.Name = "label1";
			label1.Size = new Size(121, 32);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// loginButton
			// 
			loginButton.Font = new Font("Segoe UI", 15F);
			loginButton.Location = new Point(329, 248);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(98, 41);
			loginButton.TabIndex = 1;
			loginButton.Text = "Login";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += login_Button_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 18F);
			label2.Location = new Point(213, 170);
			label2.Name = "label2";
			label2.Size = new Size(111, 32);
			label2.TabIndex = 2;
			label2.Text = "Password";
			// 
			// usernameTxt
			// 
			usernameTxt.Font = new Font("Segoe UI", 18F);
			usernameTxt.Location = new Point(352, 117);
			usernameTxt.Name = "usernameTxt";
			usernameTxt.Size = new Size(184, 39);
			usernameTxt.TabIndex = 3;
			// 
			// passwordTxt
			// 
			passwordTxt.Font = new Font("Segoe UI", 18F);
			passwordTxt.Location = new Point(352, 170);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.PasswordChar = '*';
			passwordTxt.Size = new Size(184, 39);
			passwordTxt.TabIndex = 4;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(passwordTxt);
			Controls.Add(usernameTxt);
			Controls.Add(label2);
			Controls.Add(loginButton);
			Controls.Add(label1);
			Name = "LoginForm";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button loginButton;
		private Label label2;
		private TextBox usernameTxt;
		private TextBox passwordTxt;
	}
}
