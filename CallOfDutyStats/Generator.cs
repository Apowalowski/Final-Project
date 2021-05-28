using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;
namespace CallOfDutyStats
{
    public class Generator
    {
        public static IRestResponse CallOfDuty()
        {


            var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/multiplayer/Amartin743/psn");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "bd1ecdb092msh2847a1a5b49da7dp173452jsn02c795d88f0d");
            request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            return response;

        }
        //public static double SummaryCODParse(string response)
        //{
        //    var killObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["kills"].ToString());
        //    var deathObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["deaths"].ToString());
        //    var kdObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["kdRatio"].ToString());
        //    var rankObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["rank"].ToString());
        //    var headshotObj = double.Parse(JObject.Parse(response)["lifetime"]["all"]["properties"]["headshots"].ToString());
        //    //var allObj = JObject.Parse(response).GetValue("summary");

        //    //var gamerKills = allObj["kill"];

        //    //return summaryObj;
        //    List<double> stats = new List<double>();
        //    stats.Add(killObj);
        //    stats.Add(deathObj);
        //    stats.Add(kdObj);
        //    stats.Add(rankObj);
        //    stats.Add(headshotObj);
        //    //var gamer = new Gamer()
        //    //{
        //    //    Kills = killObj,
        //    //    Deaths = deathObj,
        //    //    KdRatio = kdObj,
        //    //    Rank = rankObj,
        //    //    Headshots = headshotObj


        //    //};
        //    //gamer = response;
        //    return response.ToString();
       //}
        
   
    }
}
