namespace XmlApp.Models.Fields
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class MalKalemBilgileri
    {
        [XmlElement("MalKalem")]
        public List<MalKalem> MalKalem { get; set; }

        public decimal MalKalemUsdToplami { get; set; }
    }

}
