namespace XmlApp.Models.Fields
{
    using System.Xml.Serialization;

    public class FaturaBilgileri
    {
        [XmlElement("Fatura")]
        public Fatura Fatura { get; set; }
    }

}
