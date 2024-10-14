using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlApp.Models.Fields
{
    public class IslemKonusuBilgileri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IslemKonusu { get; set; }
        public string IslemKonusuTicari { get; set; }
        public string IslemKonusuTicariOlmayan { get; set; }
    }

}
