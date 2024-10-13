namespace XmlApp.Models.Fields
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    public class MalKalemBilgileri
    {
        [Key]
        public int Id { get; set; }
        [XmlElement("MalKalem")]
        public List<MalKalem> MalKalem { get; set; }
        [XmlElement("MalKalemToplamı")]
        public decimal MalKalemUsdToplami { get; set; }
    }

}
