namespace ProjectApp
{
	partial class DashboardForm
	{
		private System.ComponentModel.IContainer components = null;

		// Required method for Designer support - do not modify
		// the contents of this method with the code editor.
		private void InitializeComponent()
		{
			label1 = new Label();
			buttonNew = new Button();
			buttonDelete = new Button();
			buttonOptions = new Button();
			dataGridViewKeys = new DataGridView();
			buttonAdminRegister = new Button();
			buttonAdminDelete = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewKeys).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(244, 45);
			label1.TabIndex = 1;
			label1.Text = "Selamat Datang";
			// 
			// buttonNew
			// 
			buttonNew.Location = new Point(12, 276);
			buttonNew.Name = "buttonNew";
			buttonNew.Size = new Size(113, 44);
			buttonNew.TabIndex = 2;
			buttonNew.Text = "New";
			buttonNew.UseVisualStyleBackColor = true;
			buttonNew.Click += buttonNew_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Location = new Point(163, 276);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(113, 44);
			buttonDelete.TabIndex = 3;
			buttonDelete.Text = "Delete";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonOptions
			// 
			buttonOptions.Location = new Point(675, 276);
			buttonOptions.Name = "buttonOptions";
			buttonOptions.Size = new Size(113, 44);
			buttonOptions.TabIndex = 4;
			buttonOptions.Text = "Options";
			buttonOptions.UseVisualStyleBackColor = true;
			buttonOptions.Click += buttonOptions_Click;
			// 
			// dataGridViewKeys
			// 
			dataGridViewKeys.AllowUserToDeleteRows = false;
			dataGridViewKeys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewKeys.Location = new Point(12, 57);
			dataGridViewKeys.Name = "dataGridViewKeys";
			dataGridViewKeys.Size = new Size(776, 175);
			dataGridViewKeys.TabIndex = 5;
			// 
			// buttonAdminRegister
			// 
			buttonAdminRegister.Location = new Point(675, 337);
			buttonAdminRegister.Name = "buttonAdminRegister";
			buttonAdminRegister.Size = new Size(113, 44);
			buttonAdminRegister.TabIndex = 6;
			buttonAdminRegister.Text = "Register";
			buttonAdminRegister.UseVisualStyleBackColor = true;
			buttonAdminRegister.Click += buttonAdminRegister_Click;
			// 
			// buttonAdminDelete
			// 
			buttonAdminDelete.Location = new Point(675, 387);
			buttonAdminDelete.Name = "buttonAdminDelete";
			buttonAdminDelete.Size = new Size(113, 44);
			buttonAdminDelete.TabIndex = 7;
			buttonAdminDelete.Text = "Delete User";
			buttonAdminDelete.UseVisualStyleBackColor = true;
			buttonAdminDelete.Click += buttonAdminDelete_Click;
			// 
			// DashboardForm
			// 
			ClientSize = new Size(800, 450);
			Controls.Add(buttonAdminDelete);
			Controls.Add(buttonAdminRegister);
			Controls.Add(dataGridViewKeys);
			Controls.Add(buttonOptions);
			Controls.Add(buttonDelete);
			Controls.Add(buttonNew);
			Controls.Add(label1);
			Name = "DashboardForm";
			Text = "Dashboard";
			Load += Dashboard_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewKeys).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		// Clean up any resources being used.
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private Label label1;
		private Button buttonNew;
		private Button buttonDelete;
		private Button buttonOptions;
		private DataGridView dataGridViewKeys;
		private Button buttonAdminRegister;
		private Button buttonAdminDelete;
	}
}
