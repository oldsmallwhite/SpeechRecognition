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
            var APP_ID = "你的 App ID";
            var API_KEY = "你的 Api Key";
            var SECRET_KEY = "你的 Secret Key";
            var client = new Baidu.Aip.Speech.Asr(APP_ID,API_KEY,SECRET_KEY);
            //var data = File.ReadAllBytes("语音pcm文件地址");
            var data = System.IO.File.ReadAllBytes("");
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