using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Serialization;
using XmlApp.Models;
using XmlApp.Models.Fields;

namespace XmlApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            var xmlStr = await reader.ReadToEndAsync();

            var sbifBilgileri = DeserializeXmlAsync(xmlStr);
            return View();
        }

        public async Task<SBIFBilgileri> DeserializeXmlAsync(string xml)
        {
           
            XmlSerializer serializer = new XmlSerializer(typeof(SBIFBilgileri));
            using (var reader = new StreamReader(xml))
            {
                return (SBIFBilgileri)serializer.Deserialize(reader);
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
