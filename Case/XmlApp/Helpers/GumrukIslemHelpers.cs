
using XmlApp.Models.Fields;
using XmlApp.ViewModels;

namespace XmlApp.Helpers
{
    public static class GumrukIslemHelpers
    {
        public static GumrukDataTableModel ToDataTableModel(this SBIFBilgileri sbif)
        {
            var viewModel = new GumrukDataTableModel();
            viewModel.FaturaNo = sbif.FaturaBilgileri.Fatura.FaturaNo;
            viewModel.FaturaTuru = sbif.FaturaBilgileri.Fatura.FaturaTuru;
            viewModel.FaturaTarih = sbif.FaturaBilgileri.Fatura.FaturaTarih;
            viewModel.OdemeSekli = sbif.FaturaBilgileri.Fatura.OdemeSekli;
            viewModel.FaturaTeslimSekli = sbif.FaturaBilgileri.Fatura.FaturaTeslimSekli;
            viewModel.FaturaTutari = sbif.FaturaBilgileri.Fatura.FaturaTutari;
            viewModel.FaturaParaBirimi = sbif.FaturaBilgileri.Fatura.FaturaParaBirimi;
            viewModel.FonDekontDekontNo = sbif.SbifBilgiFisi == null ? string.Empty : sbif.SbifBilgiFisi.FonDekont.FonDekontDekontNo;
            viewModel.FonDekontTarih = sbif.SbifBilgiFisi == null ? string.Empty : sbif.SbifBilgiFisi.FonDekont.FonDekontTarih;
            viewModel.FonDekontTutarPB = sbif.SbifBilgiFisi == null ? string.Empty : sbif.SbifBilgiFisi.FonDekont.FonDekontTutarPB;
            viewModel.FonDekontKullanilan = sbif.SbifBilgiFisi == null ? 0 : sbif.SbifBilgiFisi.FonDekont.FonDekontKullanilan;
            viewModel.FonDekontKullanilanPB = sbif.SbifBilgiFisi == null ? string.Empty : sbif.SbifBilgiFisi.FonDekont.FonDekontKullanilanPB;
            viewModel.FonDekontKullanilanDolar = sbif.SbifBilgiFisi == null ? 0 : sbif.SbifBilgiFisi.FonDekont.FonDekontKullanilanDolar;
            viewModel.BelgeNo = sbif.GenelBilgiler.BelgeNo;
            viewModel.SerbestBolgeAdi = sbif.GenelBilgiler.SerbestBolgeAdi;
            viewModel.KayitTarihi = sbif.GenelBilgiler.KayitTarihi;
            viewModel.DisReferansNo = sbif.GenelBilgiler.DisReferansNo;
            viewModel.GumrukId = sbif.GenelBilgiler.GumrukId;
            viewModel.FormDurumu = sbif.GenelBilgiler.FormDurumu;
            viewModel.FirmaTicaretUnvani = sbif.GenelBilgiler.FirmaTicaretUnvani;
            viewModel.FirmaFaaliyetRuhsatiNo = sbif.GenelBilgiler.FirmaFaaliyetRuhsatiNo;
            viewModel.FirmaFaaliyetRuhsatiKonusu = sbif.GenelBilgiler.FirmaFaaliyetRuhsatiKonusu;
            viewModel.DepoKullanimBelgeliFirma = sbif.GenelBilgiler.DepoKullanimBelgeliFirma;
            viewModel.DepoKullanimBelgeNo = sbif.GenelBilgiler.DepoKullanimBelgeNo;
            viewModel.FormuDolduraninAdi = sbif.GenelBilgiler.FormuDolduraninAdi;
            viewModel.FirmaTelefonu = sbif.GenelBilgiler.FirmaTelefonu;
            viewModel.IslemYonu = sbif.GenelBilgiler.IslemYonuBilgileri.IslemYonu;
            viewModel.IslemTuru = sbif.GenelBilgiler.IslemTuruBilgileri.IslemTuru;
            viewModel.IslemKonusu = sbif.GenelBilgiler.IslemKonusuBilgileri.IslemKonusu;
            viewModel.IslemKonusuTicari = sbif.GenelBilgiler.IslemKonusuBilgileri.IslemKonusuTicari;
            viewModel.IslemKonusuTicariOlmayan = sbif.GenelBilgiler.IslemKonusuBilgileri.IslemKonusuTicariOlmayan;
            viewModel.SevkiyatSekliAdi = sbif.GenelBilgiler.SevkiyatSekli.SevkiyatSekliAdi;
            viewModel.AdiTicaretUnvani = sbif.FaturaBilgileri.Fatura.TeslimAdresi.AdiTicaretUnvani;
            viewModel.Adresi = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Adresi;
            //Postakodu = sbif.FaturaBilgileri.Fatura.TeslimAdresi.PostaKodu;
            viewModel.Ulke = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Ulke;
            viewModel.Il = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Il;
            viewModel.Ilce = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Ilce;
            viewModel.Telefon1 = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Telefon1;
            viewModel.Telefon2 = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Telefon2;
            viewModel.Telefon3 = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Telefon3;
            //Fax1 = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Faks1;
            //Fax2 = sbif.FaturaBilgileri.Fatura.TeslimAdresi.Faks2;
            //Eposta = sbif.FaturaBilgileri.Fatura.TeslimAdresi.EPosta;
            viewModel.AdiUnvani = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.AdiUnvani;
            viewModel.VergiKimlikNo = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.VergiKimlikNo;
            viewModel.VergiDairesi = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.VergiDairesi;
            //Adresi = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Adresi;
            viewModel.PostaKodu = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.PostaKodu;
            //Ulke = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Ulke;
            //Il = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Il;
            //Ilce = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Ilce;
            //Telefon1 = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Telefon1;
            //Telefon2 = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Telefon2;
            //Telefon3 = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Telefon3;
            viewModel.Faks1 = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Faks1;
            viewModel.Faks2 = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.Faks2;
            viewModel.WebAdresi = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.WebAdresi;
            //Eposta = sbif.FaturaBilgileri.Fatura.KarsiFirmaBilgisi.EPosta;
            viewModel.OrtakDepo = sbif.TalepEdilenIsleticiHizmetleri.OrtakDepo;
            viewModel.Kantar = sbif.TalepEdilenIsleticiHizmetleri.Kantar;
            viewModel.YuklemeBosaltma = sbif.TalepEdilenIsleticiHizmetleri.YuklemeBosaltma;
            viewModel.IsMakinasi = sbif.TalepEdilenIsleticiHizmetleri.IsMakinasi;
            viewModel.Ellecleme = sbif.TalepEdilenIsleticiHizmetleri.Ellecleme;
            viewModel.KoordinasyonHizmeti = sbif.TalepEdilenIsleticiHizmetleri.KoordinasyonHizmeti;
            viewModel.DigerTalepEdilenHizmetler = sbif.TalepEdilenIsleticiHizmetleri.DigerTalepEdilenHizmetler;
            viewModel.MalKalemUsdToplami = sbif.MalKalemBilgileri.MalKalemUsdToplami;
            viewModel.GumBeyannameNo = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMudurluguOnayi.GumBeyannameNo;
            viewModel.GumTescilTarihi = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMudurluguOnayi.GumTescilTarihi;
            viewModel.GumTescilNo = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMudurluguOnayi.GumTescilNo;
            viewModel.GumIslemiOnaylayaninAdiSoyadi = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMudurluguOnayi.GumIslemiOnaylayaninAdiSoyadi;
            viewModel.GumMuhOnaylayanAdi = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMuhafazaMudurluguOnayi.GumMuhOnaylayanAdi;
            viewModel.GumMuhTescilNumarasi = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMuhafazaMudurluguOnayi.GumMuhTescilNumarasi;
            viewModel.GumMuhTescilTarihi = sbif.SbifGumrukBilgileri == null ? string.Empty : sbif.SbifGumrukBilgileri.GumrukMuhafazaMudurluguOnayi.GumMuhTescilTarihi;

            return viewModel;
        }
    }
}
