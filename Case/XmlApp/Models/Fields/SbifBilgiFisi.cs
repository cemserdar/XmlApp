using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlApp.Models.Fields
{
    public class SbifBilgiFisi
    {
        [Key]
        public int Id { get; set; }
      
        public FonDekont FonDekont { get; set; }
    }

}
