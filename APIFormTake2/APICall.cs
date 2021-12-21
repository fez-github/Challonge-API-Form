using System;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using System.Collections.Specialized;
using RestSharp;
using RestSharp.Authenticators;
using System.Windows.Forms;

namespace APIFormTake2
{
public class APICall
    {
        string results;
        HttpUtility http = new HttpUtility();
        RestClient client = new RestClient("https://api.challonge.com/v1/");
        public string /*async void*/ GetCall(string url, string key)
        {
            client.AddDefaultHeader("Content-Type", "application/json");
            client.Authenticator = new HttpBasicAuthenticator("FEZelda", key);
            RestRequest request = new RestRequest("tournaments", Method.GET, DataFormat.Json);
            //request.AddParameter("api_key", key);
            IRestResponse response = client.Execute(request);
            return response.StatusCode.ToString();
            //RestResponse response = await client.GetAsync<RestResponse>(request);
            /*
            await Task.Run(() =>
            {
                System.IO.File.WriteAllText("filepath", response.Content);
            });
            */
            //await CallWebAPIAsync(client, request);

            /*
            client.Timeout = -1; //Will never timeout.
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            var body = < SerialisedJson > ();
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            request.Addjs
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            */

        }
        public string PostCall(string tournName, string key)
        {

            //client.AddDefaultHeader("Content-Type", "application/json");
            client.Authenticator = new HttpBasicAuthenticator("FEZelda", key);
            RestRequest request = new RestRequest("tournaments", DataFormat.Json);
            request.AddParameter("tournament[name]", tournName);
            /*var obj = new Tournament
            {
                name = tournName
            };
            request.AddJsonBody(obj); */
            //return request.Body.Value.ToString();
            IRestResponse response = client.Post(request);
            return response.StatusCode.ToString();

            //Unauthorized?  How come?
            //POST does not read parameters?
        }
        public string PutCall(string tournName, string tournDesc, string key)
        {
            client.Authenticator = new HttpBasicAuthenticator("FEZelda", key);
            RestRequest request = new RestRequest("tournaments/" + tournName, Method.PUT, DataFormat.Json);
            //request.AddParameter("{tournament}", tournName);
            request.AddParameter("tournament[description]", tournDesc);
            IRestResponse response = client.Put(request);
            return response.StatusCode.ToString();
        }
        public string DeleteCall(string tournName, string key)
        {
            client.Authenticator = new HttpBasicAuthenticator("FEZelda", key);
            RestRequest request = new RestRequest("tournaments/" + tournName, DataFormat.Json);
            IRestResponse response = client.Delete(request);
            return response.StatusCode.ToString();
        }



        /// <summary>
        /// Adds query parameters to a URI.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public UriBuilder URIParamsAdd(UriBuilder builder, Dictionary<string, string> dict)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);

            foreach (KeyValuePair<string, string> entry in dict)
            {
                query[entry.Key] = query[entry.Key] + entry.Value;
            }

            builder.Query = query.ToString();
            return builder;
        }
        public async Task CallWebAPIAsync(RestClient client, RestRequest request)
        {
            await Task.Run(() =>
            {
                IRestResponse response = client.Get(request);
                if (response.IsSuccessful)
                {
                    System.IO.File.WriteAllText("filepath", response.Content);
                }
            });
            /*
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(builder.Uri.AbsoluteUri);
                Console.WriteLine(builder.Uri.AbsoluteUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                await Task.Run(() =>
                {
                    HttpResponseMessage response = client.Send(new HttpRequestMessage(HttpMethod.Get, client.BaseAddress));
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Success");
                        System.IO.File.WriteAllText(filepath, response.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        Console.WriteLine(response.StatusCode);
                    }
                });
            }
            */
        }
        public void NewGetCall(string username, string key, string method, string resource, Dictionary<string, string> parameters, string reqBody)
        {
            client.Authenticator = new HttpBasicAuthenticator(username, key);
            Method meth = new Method();
            switch (method)
            {
                case "GET":
                    meth = Method.GET;
                    break;
                case "POST":
                    meth = Method.POST;
                    break;
                case "PUT":
                    meth = Method.PUT;
                    break;
                case "DELETE":
                    meth = Method.DELETE;
                    break;
            }
            RestRequest request = new RestRequest(resource, meth, DataFormat.Json);

            foreach(KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            if(reqBody != null)
            {
                request.AddParameter("application/json", reqBody, ParameterType.RequestBody);
            }
            IRestResponse response = client.Execute(request);
            if(method == "GET")
            {
                MessageBox.Show(response.Content);
            }
        }
    }

}
