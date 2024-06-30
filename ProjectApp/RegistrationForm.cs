using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectApp
{
	public partial class RegistrationForm : Form
	{
		private static readonly HttpClientHandler handler = new HttpClientHandler()
		{
			// Bypass SSL certificate validation
			ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
		};
		private HttpClient client;

		public RegistrationForm()
		{
			InitializeComponent();
			client = new HttpClient(handler);
		}

		private async void buttonRegister_Click(object sender, EventArgs e)
		{
			try
			{
				string token = Auth.GetToken();

				if (string.IsNullOrEmpty(token))
				{
					MessageBox.Show("Token not found, please login again.");
					return;
				}

				// Ambil data dari kontrol input
				string id = idTxt.Text;
				string name = nameTxt.Text;
				string username = usernameTxt.Text;
				string password = passwordTxt.Text;
				string alamat = alamatTxt.Text;

				// Buat objek berisi data untuk dikirimkan ke API
				var values = new
				{
					id = id,
					name = name,
					username = username,
					password = password,
					alamat = alamat
				};

				var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				HttpResponseMessage response = await client.PostAsync("https://localhost:8443/api/user/register", content);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Registration successful!");
					this.Close();
				}
				else
				{
					var errorResponse = await response.Content.ReadAsStringAsync();
					var errorMessage = ErrorHandler.ExtractErrorMessage(errorResponse);
					MessageBox.Show($"Error registering user: {response.ReasonPhrase}\nDetails: {errorMessage}");
				}
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"HTTP Error occurred: {ex.Message}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}");
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
