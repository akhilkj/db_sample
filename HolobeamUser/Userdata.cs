using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HolobeamUser
{
    public class Userdata
    {


        public async System.Threading.Tasks.Task PostUserAsync(string uname, string email, string photo)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
            {
             { "username", uname },
             { "emailid", email },
             {"photo", photo }
            };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("http://localhost:60261/api/Values/AddingUser", content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
            
        }

        //public void PostUser(string uname, string email, string photo)
        //{

        //    //using (var client = new WebClient())
        //    //{
        //    //    var values = new NameValueCollection();
        //    //    values["username"] = uname;
        //    //    values["emailid"] = email;
        //    //    values["photo"] = photo;

        //    //    var response = client.UploadValues("http://localhost:60261/api/Values/AddingUser", values);

        //    //    var responseString = Encoding.Default.GetString(response);
        //    //}

        //}
        public void GetUser(string Username)
        {
            
            using (var client = new System.Net.Http.HttpClient())
            {
                // HTTP POST
                
                client.BaseAddress = new Uri("http://localhost:60261/api/Values/GetDetails");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("http://localhost:60261/api/Values/GetDetails?uname="+Username).Result;
                string res = "";
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                }
                Console.WriteLine(res);
            }
            Console.Read();
        }
            


        
         
    }
}
