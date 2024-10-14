namespace XmlApp.Models.Fields
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    [XmlRoot("SBIFBilgileri")]
    public class SBIFBilgileri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? SbifGumrukBilgileriId { get; set; }
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
        public int? SbifBilgiFisiId { get; set; }
        [XmlElement("SbifGumrukBilgileri")]
        public SbifGumrukBilgileri SbifGumrukBilgileri { get; set; }
    }

}
