namespace XmlApp.Models.Fields
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    public class Fatura
    {
        [Key]
        public string FaturaNo { get; set; }
        public string FaturaTuru { get; set; }
        public string FaturaTarih { get; set; }
        [XmlElement("TeslimAdresi")]
        public TeslimAdresi TeslimAdresi { get; set; }
        [XmlElement("KarsiFirmaBilgisi")]
        public KarsiFirmaBilgisi KarsiFirmaBilgisi { get; set; }
        public string OdemeSekli { get; set; }
        public string FaturaTeslimSekli { get; set; }
        public decimal FaturaTutari { get; set; }
        public string FaturaParaBirimi { get; set; }
        [NotMapped]
        public FaturaBilgileri FaturaBilgileri { get; set; }
    }

}
