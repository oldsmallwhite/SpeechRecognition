using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.IO.Pipes;
using Baidu.Aip;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            // 设置APPID/AK/SK
            var APP_ID = "11618610";
            var API_KEY = "zmskrQcqn3wOwgpgXne3sUIO";
            var SECRET_KEY = "2hwb1GRzjArFP1hrfG4mny6qsak47lXD ";
            var client = new Baidu.Aip.Speech.Asr(APP_ID,API_KEY,SECRET_KEY);
            var data = System.IO.File.ReadAllBytes("C:/16k.pcm");
            client.Timeout = 120000; // 若语音较长，建议设置更大的超时时间. ms
            var result = client.Recognize(data, "pcm", 16000);
            return "";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}