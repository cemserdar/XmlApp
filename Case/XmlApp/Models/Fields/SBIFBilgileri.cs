namespace XmlApp.Models.Fields
{
    using System;
    using System.Xml.Serialization;

    [XmlRoot("SBIFBilgileri")]
    public class SBIFBilgileri
    {
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
