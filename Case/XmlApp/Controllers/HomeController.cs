using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Serialization;
using XmlApp.Data;
using XmlApp.Extension;
using XmlApp.Models;
using XmlApp.Models.Fields;

namespace XmlApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public IActionResult Index()
        {

            return RedirectToAction("Upload");
        }
    
        public IActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile xmlFile)
        {
            CheckXmlValidations(xmlFile);
            if (xmlFile != null && xmlFile.Length > 0)
            {
                using (var reader = new StreamReader(xmlFile.OpenReadStream(), Encoding.UTF8))
                {
                    var xmlStr = await reader.ReadToEndAsync();
                    var sbifBilgileri = DeserializeXml(xmlStr);
                    dataContext.Add(sbifBilgileri);
                    dataContext.SaveChanges();
                    return Ok("Ba�ar�l�"); 
                }
            }

            ModelState.AddModelError("", "L�tfen bir XML dosyas� y�kleyin.");
            return View();
        }
        private SBIFBilgileri DeserializeXml(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SBIFBilgileri));
            using (var reader = new StringReader(xml))
            {
                return (SBIFBilgileri)serializer.Deserialize(reader);
            }
        }
        private void CheckXmlValidations(IFormFile xmlFile)
        {
            if (xmlFile == null || xmlFile.Length == 0)
                throw new Exception("Y�klenmeye �al���lan dosya ge�ersiz ya da bo�, l�tfen ge�erli bir dosya deneyiniz.");

            if (!xmlFile.IsXml())
                throw new Exception("Sadece xml uzant�l� dosyalar� y�kleyebilirsiniz.");
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
