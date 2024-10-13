using System.ComponentModel.DataAnnotations;

namespace XmlApp.Models.Fields
{
    public class TalepEdilenIsleticiHizmetleri
    {
        [Key]
        public int Id { get; set; }
        public string OrtakDepo { get; set; }
        public string Kantar { get; set; }
        public string YuklemeBosaltma { get; set; }
        public string IsMakinasi { get; set; }
        public string Ellecleme { get; set; }
        public string KoordinasyonHizmeti { get; set; }
        public string DigerTalepEdilenHizmetler { get; set; }
    }

}
