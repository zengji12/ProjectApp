namespace ProjectApp
{
	partial class ReNewPassForm
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
			oldPass = new Label();
			newPass = new Label();
			submitPass = new Button();
			OldTextBox = new TextBox();
			NewTextBox = new TextBox();
			backButton = new Button();
			SuspendLayout();
			// 
			// oldPass
			// 
			oldPass.AutoSize = true;
			oldPass.Location = new Point(7, 41);
			oldPass.Name = "oldPass";
			oldPass.Size = new Size(79, 15);
			oldPass.TabIndex = 0;
			oldPass.Text = "Old Password";
			// 
			// newPass
			// 
			newPass.AutoSize = true;
			newPass.Location = new Point(7, 93);
			newPass.Name = "newPass";
			newPass.Size = new Size(84, 15);
			newPass.TabIndex = 1;
			newPass.Text = "New Password";
			// 
			// submitPass
			// 
			submitPass.Location = new Point(122, 157);
			submitPass.Name = "submitPass";
			submitPass.Size = new Size(75, 23);
			submitPass.TabIndex = 2;
			submitPass.Text = "Confirm";
			submitPass.UseVisualStyleBackColor = true;
			submitPass.Click += submitPass_Click;
			// 
			// OldTextBox
			// 
			OldTextBox.Location = new Point(97, 38);
			OldTextBox.Name = "OldTextBox";
			OldTextBox.PasswordChar = '*';
			OldTextBox.Size = new Size(100, 23);
			OldTextBox.TabIndex = 3;
			// 
			// NewTextBox
			// 
			NewTextBox.Location = new Point(97, 90);
			NewTextBox.Name = "NewTextBox";
			NewTextBox.PasswordChar = '*';
			NewTextBox.Size = new Size(100, 23);
			NewTextBox.TabIndex = 4;
			// 
			// backButton
			// 
			backButton.Location = new Point(16, 157);
			backButton.Name = "backButton";
			backButton.Size = new Size(75, 23);
			backButton.TabIndex = 5;
			backButton.Text = "Back";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click;
			// 
			// ReNewPassForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(219, 207);
			Controls.Add(backButton);
			Controls.Add(NewTextBox);
			Controls.Add(OldTextBox);
			Controls.Add(submitPass);
			Controls.Add(newPass);
			Controls.Add(oldPass);
			Name = "ReNewPassForm";
			Text = "Re New Password";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label oldPass;
		private Label newPass;
		private Button submitPass;
		private TextBox OldTextBox;
		private TextBox NewTextBox;
		private Button backButton;
	}
}
