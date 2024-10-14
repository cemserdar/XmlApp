using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlApp.Models.Fields
{
    public class GumrukMuhafazaMudurluguOnayi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GumMuhOnaylayanAdi { get; set; }
        public string GumMuhTescilNumarasi { get; set; }
        public string GumMuhTescilTarihi { get; set; }
    }

}
