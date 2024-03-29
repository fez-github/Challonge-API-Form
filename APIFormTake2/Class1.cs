﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace APIForm
{
    public class Class1
    {
        HttpUtility http = new HttpUtility();
        static void RunCall(string URL, string Key)
        {
            UriBuilder builder = new UriBuilder(URL);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("include_participants", "1");
            dictionary.Add("include_matches", "1");
            dictionary.Add("api_key", Key);
            builder = URIParamsAdd(builder, dictionary);
            CallWebAPIAsync(builder).Wait();
        }
        /// <summary>
        /// Adds query parameters to a URI.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static UriBuilder URIParamsAdd(UriBuilder builder, Dictionary<string, string> dict)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);

            foreach (KeyValuePair<string, string> entry in dict)
            {
                query[entry.Key] = query[entry.Key] + entry.Value;
            }

            builder.Query = query.ToString();
            return builder;
        }
        public static async Task CallWebAPIAsync(UriBuilder builder)
        {
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
                        System.IO.File.WriteAllText("C:\\Users\\Mark\\Downloads\\jsonTest.json", response.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        Console.WriteLine(response.StatusCode);
                    }
                });
            }
        }
    }

}
