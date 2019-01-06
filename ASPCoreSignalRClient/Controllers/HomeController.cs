using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreSignalRClient.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace ASPCoreSignalRClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWebAPI(string sepal_length, string sepal_width,
            string petal_length, string petal_width)
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
                                                "sepal-length", sepal_length
                                            },
                                            {
                                                "sepal-width", sepal_width
                                            },
                                            {
                                                "petal-length", petal_length
                                            },
                                            {
                                                "petal-width", petal_width
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

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic jsonResult = JsonConvert.DeserializeObject(result);


                    return Content(Convert.ToString(jsonResult));
                    //string endResult = Convert.ToString(jsonResult.Results.output1[0]);
                    //var jsonResult2 = JsonConvert.DeserializeObject<Hasil>(endResult);

                    //return Content($"Scored Labels : {jsonResult2.ScoredLabels} Scored Probabilities: {jsonResult2.ScoredProbabilities}");
                }
                else
                {
                    return Content(string.Format("The request failed with status code: {0}", response.StatusCode));
                }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
