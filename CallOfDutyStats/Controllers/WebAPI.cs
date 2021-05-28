using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CallOfDutyStats.Controllers
{
    public class WebAPI : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IEnumerable<string> Get()
        public static IRestResponse CallOfDuty()
        {
            //return new string[] { "value1", "value2" };
            var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/multiplayer/Amartin743/psn");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "bd1ecdb092msh2847a1a5b49da7dp173452jsn02c795d88f0d");
            request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            return response;


        }

        // GET: api/values/5
        public IActionResult MakeGamer(string gtag)
        {
            //var summaryObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["kills"].ToString());
            //return summaryObj;
            var client = new RestClient($"https://call-of-duty-modern-warfare.p.rapidapi.com/multiplayer/{gtag}/psn");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "bd1ecdb092msh2847a1a5b49da7dp173452jsn02c795d88f0d");
            request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var gamer = new Gamer();
            var jsonObject = JObject.Parse(response.Content);
            gamer.Kills = double.Parse(HandleIfContentIsNull(jsonObject["lifetime"]["all"]["properties"]["kills"]));
            gamer.Deaths = double.Parse(HandleIfContentIsNull(jsonObject["lifetime"]["all"]["properties"]["deaths"]));
            gamer.KdRatio = double.Parse(HandleIfContentIsNull(jsonObject["lifetime"]["all"]["properties"]["kdRatio"]));
            gamer.Headshots = double.Parse(HandleIfContentIsNull(jsonObject["lifetime"]["all"]["properties"]["headshots"]));
            gamer.Rank = double.Parse(HandleIfContentIsNull(jsonObject["lifetime"]["all"]["properties"]["rank"]));
            //gamer.Death


            return View(gamer);
        }
        public static string HandleIfContentIsNull(JToken apiNode)
        {
            if (apiNode == null)
            {
                return "0";
            }

            return apiNode.ToString();
        }


        // POST: api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}
