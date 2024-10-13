namespace XmlApp.Models.Fields
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    public class GenelBilgiler
    {
        [Key]
        public int Id { get; set; }
        public string BelgeNo { get; set; }
        public string SerbestBolgeAdi { get; set; }
        public string KayitTarihi { get; set; }
        public string DisReferansNo { get; set; }
        public string GumrukId { get; set; }
        public string FormDurumu { get; set; }
        public string FirmaTicaretUnvani { get; set; }
        public string FirmaFaaliyetRuhsatiNo { get; set; }
        public string FirmaFaaliyetRuhsatiKonusu { get; set; }
        public string DepoKullanimBelgeliFirma { get; set; }
        public string DepoKullanimBelgeNo { get; set; }
        public string FormuDolduraninAdi { get; set; }
        public string FirmaTelefonu { get; set; }

        [XmlElement("IslemYonuBilgileri")]
        [NotMapped]
        public IslemYonuBilgileri IslemYonuBilgileri { get; set; }

        [XmlElement("IslemTuruBilgileri")]
        [NotMapped]
        public IslemTuruBilgileri IslemTuruBilgileri { get; set; }

        [XmlElement("IslemKonusuBilgileri")]
        [NotMapped]
        public IslemKonusuBilgileri IslemKonusuBilgileri { get; set; }

        [XmlElement("SevkiyatSekli")]
        
        public SevkiyatSekli SevkiyatSekli { get; set; }
    }

}
