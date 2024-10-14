using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlApp.Models.Fields
{
    public class GumrukMudurluguOnayi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GumBeyannameNo { get; set; }
        public string GumTescilTarihi { get; set; }
        public string GumTescilNo { get; set; }
        public string GumIslemiOnaylayaninAdiSoyadi { get; set; }
    }

}
