using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectApp
{
	public partial class DashboardForm : Form
	{
		private static readonly HttpClientHandler handler = new HttpClientHandler()
		{
			// Bypass SSL certificate validation
			ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
		};
		private string fullname;
		private HttpClient client;
		private bool isAdmin;

		public DashboardForm(string fullname)
		{
			InitializeComponent();
			this.fullname = fullname;
			client = new HttpClient(handler);
			isAdmin = false;
		}

		private async void Dashboard_Load(object sender, EventArgs e)
		{
			label1.Text = $"Selamat Datang {fullname}";
			await CheckAdminStatus();
			buttonAdminRegister.Visible = isAdmin;
			buttonAdminDelete.Visible = isAdmin;
			await LoadUserKeysAsync();
		}

		private async Task LoadUserKeysAsync()
		{
			try
			{
				string token = Auth.GetToken();

				if (string.IsNullOrEmpty(token))
				{
					MessageBox.Show("Token not found, please login again.");
					return;
				}

				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var response = await client.PostAsync("https://localhost:8443/api/user/getkey", null);

				response.EnsureSuccessStatusCode();

				var content = await response.Content.ReadAsStringAsync();
				Console.WriteLine($"Response: {content}");

				if (string.IsNullOrEmpty(content))
				{
					MessageBox.Show("No keys found for the user.");
					return;
				}

				var keys = JsonConvert.DeserializeObject<ApiKey[]>(content);

				dataGridViewKeys.DataSource = null;
				dataGridViewKeys.DataSource = keys;
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error fetching user keys: {ex.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}");
			}
		}

		private async Task CheckAdminStatus()
		{
			try
			{
				string token = Auth.GetToken();

				if (string.IsNullOrEmpty(token))
				{
					MessageBox.Show("Token not found, please login again.");
					return;
				}

				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var response = await client.PostAsync("https://localhost:8443/api/auth/isadmin", null);

				response.EnsureSuccessStatusCode();

				var content = await response.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<dynamic>(content);
				isAdmin = result.isAdmin;
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error checking admin status: {ex.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}");
			}
		}
		private void listkey_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Handle item selection if needed
		}

		private async void buttonNew_Click(object sender, EventArgs e)
		{
			try
			{
				string token = Auth.GetToken();

				if (string.IsNullOrEmpty(token))
				{
					MessageBox.Show("Token not found, please login again.");
					return;
				}

				string label = ShowInputDialog("Enter Label", null);
				if (string.IsNullOrEmpty(label))
				{
					MessageBox.Show("Label cannot be empty.");
					return;
				}

				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var values = new { label = label };
				var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PostAsync("https://localhost:8443/api/user/newkey", content);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Key created successfully!");
					await LoadUserKeysAsync();
				}
				else
				{
					var errorResponse = await response.Content.ReadAsStringAsync();
					var errorMessage = ErrorHandler.ExtractErrorMessage(errorResponse);
					MessageBox.Show($"Error creating key: {response.ReasonPhrase}\nDetails: {errorMessage}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error creating key: {ex.Message}");
			}
		}


		private string ShowInputDialog(string caption, string defaultValue)
		{
			Form prompt = new Form()
			{
				Width = 500,
				Height = 220,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = caption,
				StartPosition = FormStartPosition.CenterScreen
			};
			Label textLabel = new Label() { Left = 50, Top = 20, Text = caption };
			TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Text = defaultValue };
			Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 90, DialogResult = DialogResult.OK };
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.Controls.Add(textBox);
			prompt.AcceptButton = confirmation;

			return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
		}

		private async void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string token = Auth.GetToken();

				if (string.IsNullOrEmpty(token))
				{
					MessageBox.Show("Token not found, please login again.");
					return;
				}

				string label = ShowInputDialog("Enter Label", null);
				if (string.IsNullOrEmpty(label))
				{
					MessageBox.Show("Label cannot be empty.");
					return;
				}

				string privateKey = GetPrivateKeyByLabel(label);
				if (string.IsNullOrEmpty(privateKey))
				{
					MessageBox.Show("Private key not found for the given label.");
					return;
				}

				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

				var values = new { label = label, privateKey = privateKey };
				var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PostAsync("https://localhost:8443/api/user/deletekey", content);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Key deleted successfully!");
					await LoadUserKeysAsync();
				}
				else
				{
					var errorResponse = await response.Content.ReadAsStringAsync();
					var errorMessage = ErrorHandler.ExtractErrorMessage(errorResponse);
					MessageBox.Show($"Error deleting key: {response.ReasonPhrase}\nDetails: {errorMessage}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error deleting key: {ex.Message}");
			}
		}

		private string GetPrivateKeyByLabel(string label)
		{
			foreach (DataGridViewRow row in dataGridViewKeys.Rows)
			{
				if (row.Cells["Label"].Value?.ToString() == label)
				{
					return row.Cells["Private"].Value?.ToString();
				}
			}
			return null;
		}

		private void buttonOptions_Click(object sender, EventArgs e)
		{
			OptionsForm optionsForm = new OptionsForm();
			optionsForm.ShowDialog();
		}

		private void buttonAdminRegister_Click(object sender, EventArgs e)
		{
			if (isAdmin)
			{
				RegistrationForm registrationForm = new RegistrationForm();
				registrationForm.Show();
			}
			else
			{
				MessageBox.Show("You do not have permission to access this feature.");
			}
		}

		private void buttonAdminDelete_Click(object sender, EventArgs e)
		{
			if (isAdmin)
			{
				DeleteUserForm deleteUserForm = new DeleteUserForm();
				deleteUserForm.Show();
			}
			else
			{
				MessageBox.Show("You do not have permission to access this feature.");
			}
		}
	}
}
