using System.ComponentModel.DataAnnotations;

namespace XmlApp.Models.Fields
{
    public class SbifGumrukBilgileri
    {
        [Key]
        public int SbifGumrukBilgileriId { get; set; }
        public GumrukMudurluguOnayi GumrukMudurluguOnayi { get; set; }
        public GumrukMuhafazaMudurluguOnayi GumrukMuhafazaMudurluguOnayi { get; set; }
    }

}
