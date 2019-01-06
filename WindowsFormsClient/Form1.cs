using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Class", "1"
                                            },
                                            {
                                                "sepal-length", txtSepalLength.Text
                                            },
                                            {
                                                "sepal-width", txtSepalWidth.Text
                                            },
                                            {
                                                "petal-length", txtPetalLength.Text
                                            },
                                            {
                                                "petal-width", txtPetalWidth.Text
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "FYT7/RTnqbT/6i9TGNKGQQCiYNowmIK9ACpNuMMEcJzxzmo2aVcGKGQSbExJN5Ub0G416as6nNk9yUCnjb121A=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/2184572330564902bdafc6ff5145c22f/services/4595c4c853c74f14bbaa69c46c928a26/execute?api-version=2.0&format=swagger");

                HttpResponseMessage response = client.PostAsJsonAsync("", scoreRequest).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    dynamic jsonResult = JsonConvert.DeserializeObject(result);

                    string endResult = Convert.ToString(jsonResult.Results.output1[0]);
                    var jsonResult2 = JsonConvert.DeserializeObject<Hasil>(endResult);

                    txtScored.Text = jsonResult2.ScoredLabels;
                    txtScoredProbabilities.Text = jsonResult2.ScoredProbabilities;
                }
                else
                {
                    MessageBox.Show("Kesalahan: Gagal akses rest services", "Pesan Kesalahan");
                }
            }
        }
    }
}
