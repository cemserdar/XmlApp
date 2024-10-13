namespace XmlApp.Models.Fields
{
    using System.Xml.Serialization;

    public class Fatura
    {
        public string FaturaTuru { get; set; }
        public string FaturaTarih { get; set; }
        public string FaturaNo { get; set; }

        [XmlElement("TeslimAdresi")]
        public TeslimAdresi TeslimAdresi { get; set; }

        [XmlElement("KarsiFirmaBilgisi")]
        public KarsiFirmaBilgisi KarsiFirmaBilgisi { get; set; }

        public string OdemeSekli { get; set; }
        public string FaturaTeslimSekli { get; set; }
        public decimal FaturaTutari { get; set; }
        public string FaturaParaBirimi { get; set; }
    }

}
