namespace XmlApp.Models.Fields
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlRoot("SBIFBilgileri")]
    public class SBIFBilgileri
    {
        [Key]
        public int Id { get; set; }

        [XmlElement("GenelBilgiler")]
        public GenelBilgiler GenelBilgiler { get; set; }

        [XmlElement("FaturaBilgileri")]
        public FaturaBilgileri FaturaBilgileri { get; set; }

        [XmlElement("MalKalemBilgileri")]
        public MalKalemBilgileri MalKalemBilgileri { get; set; }

        [XmlElement("TalepEdilenIsleticiHizmetleri")]
        public TalepEdilenIsleticiHizmetleri TalepEdilenIsleticiHizmetleri { get; set; }

        [XmlElement("SbifBilgiFisi")]
        public SbifBilgiFisi SbifBilgiFisi { get; set; }
    }

}
