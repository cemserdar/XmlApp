namespace XmlApp.Models.Fields
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    public class FaturaBilgileri
    {
        [Key]
        public int Id { get; set; }
        [XmlElement("Fatura")]
        public Fatura Fatura { get; set; }
    }

}
