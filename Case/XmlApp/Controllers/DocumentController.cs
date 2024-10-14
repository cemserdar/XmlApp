using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using XmlApp.Data;
using XmlApp.Helpers;
using XmlApp.Models.Fields;
using XmlApp.ViewModels;

namespace XmlApp.Controllers
{
    public class DocumentController : Controller
    {

        private readonly DataContext _dataContext;

        public DocumentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var list = GetAll().Select(q => q.ToDataTableModel()).ToList();

            var viewModel = new GumrukViewModel()
            {
                Columns = GetPropertyNames<GumrukDataTableModel>(),
                data = list
            };


            return View(viewModel);
        }
        public static List<string> GetPropertyNames<T>()
        {
            return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Select(prop => prop.Name)
                            .ToList();
        }
        public IActionResult GetGumrukData()
        {

            return Ok();
        }

        public List<SBIFBilgileri> GetAll()
        {
            return _dataContext.SBIFBilgileri
                                   .Include(q => q.GenelBilgiler)
                                        .ThenInclude(q=>q.IslemYonuBilgileri)
                                   .Include(q => q.GenelBilgiler)
                                        .ThenInclude(q => q.IslemTuruBilgileri)
                                   .Include(q => q.GenelBilgiler)
                                        .ThenInclude(q => q.IslemKonusuBilgileri)
                                   .Include(q => q.GenelBilgiler)
                                        .ThenInclude(q => q.SevkiyatSekli)
                                   .Include(q => q.FaturaBilgileri)
                                        .ThenInclude(q => q.Fatura)
                                        .ThenInclude(q=>q.TeslimAdresi)
                                   .Include(q => q.FaturaBilgileri)
                                        .ThenInclude(q => q.Fatura)
                                        .ThenInclude(q => q.KarsiFirmaBilgisi)
                                   .Include(q => q.TalepEdilenIsleticiHizmetleri)
                                   .Include(q => q.SbifBilgiFisi)
                                        .ThenInclude(q => q.FonDekont)
                                   .Include(q => q.SbifGumrukBilgileri)
                                        .ThenInclude(q=>q.GumrukMudurluguOnayi)
                                        .Include(q => q.SbifGumrukBilgileri)
                                        .ThenInclude(q => q.GumrukMuhafazaMudurluguOnayi)
                                   .Include(q => q.MalKalemBilgileri)
                                       .ThenInclude(q => q.MalKalem)
                                   .ToList();
        }



    }
}
