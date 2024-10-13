using System.ComponentModel.DataAnnotations;

namespace XmlApp.Models.Fields
{
    public class FonDekont
    {
        [Key]
        public string FonDekontDekontNo { get; set; }
        public string FonDekontTarih { get; set; }
        public decimal FonDekontTutar { get; set; }
        public string FonDekontTutarPB { get; set; }
        public decimal FonDekontKullanilan { get; set; }
        public string FonDekontKullanilanPB { get; set; }
        public decimal FonDekontKullanilanDolar { get; set; }
    }

}
