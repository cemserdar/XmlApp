using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XmlApp.Migrations
{
    /// <inheritdoc />
    public partial class firxt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gumrukMudurluguOnayi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GumBeyannameNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumTescilTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumTescilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumIslemiOnaylayaninAdiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gumrukMudurluguOnayi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gumrukMuhafazaMudurluguOnayi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GumMuhOnaylayanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumMuhTescilNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumMuhTescilTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gumrukMuhafazaMudurluguOnayi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IslemKonusuBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemKonusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemKonusuTicari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemKonusuTicariOlmayan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemKonusuBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IslemTuruBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemTuru = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemTuruBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IslemYonuBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemYonu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemYonuBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KarsiFirmaBilgileri",
                columns: table => new
                {
                    AdiUnvani = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    VergiKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faks1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faks2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KarsiFirmaBilgileri", x => x.AdiUnvani);
                });

            migrationBuilder.CreateTable(
                name: "MalKalemBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalKalemUsdToplami = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalKalemBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SevkiyatSekli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SevkiyatSekliAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SevkiyatSekli", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalepEdilenIsleticiHizmetleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrtakDepo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kantar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuklemeBosaltma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMakinasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ellecleme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KoordinasyonHizmeti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigerTalepEdilenHizmetler = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalepEdilenIsleticiHizmetleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeslimAdresi",
                columns: table => new
                {
                    AdiTicaretUnvani = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faks1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faks2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeslimAdresi", x => x.AdiTicaretUnvani);
                });

            migrationBuilder.CreateTable(
                name: "sbifGumrukBilgileri",
                columns: table => new
                {
                    SbifGumrukBilgileriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GumrukMudurluguOnayiId = table.Column<int>(type: "int", nullable: false),
                    GumrukMuhafazaMudurluguOnayiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sbifGumrukBilgileri", x => x.SbifGumrukBilgileriId);
                    table.ForeignKey(
                        name: "FK_sbifGumrukBilgileri_gumrukMudurluguOnayi_GumrukMudurluguOnayiId",
                        column: x => x.GumrukMudurluguOnayiId,
                        principalTable: "gumrukMudurluguOnayi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sbifGumrukBilgileri_gumrukMuhafazaMudurluguOnayi_GumrukMuhafazaMudurluguOnayiId",
                        column: x => x.GumrukMuhafazaMudurluguOnayiId,
                        principalTable: "gumrukMuhafazaMudurluguOnayi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MalKalemler",
                columns: table => new
                {
                    MalKalemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false),
                    GumrukSiraNo = table.Column<int>(type: "int", nullable: false),
                    ReferansFormTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferansFormNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferansFormYil = table.Column<int>(type: "int", nullable: false),
                    ReferansFormSiraNo = table.Column<int>(type: "int", nullable: false),
                    gtip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeldigiGidecegiUlke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirinciMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BirinciBirim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KapTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KapAdedi = table.Column<int>(type: "int", nullable: false),
                    MalBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MalBedeliParaBirimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NavlunBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NavlunBedeliParaBirimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SigortaBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SigortaBedeliParaBirimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrutAgirlik = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MalKalemTeslimSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalKalemBilgileriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalKalemler", x => x.MalKalemId);
                    table.ForeignKey(
                        name: "FK_MalKalemler_MalKalemBilgileri_MalKalemBilgileriId",
                        column: x => x.MalKalemBilgileriId,
                        principalTable: "MalKalemBilgileri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenelBilgiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BelgeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerbestBolgeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisReferansNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GumrukId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaTicaretUnvani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaFaaliyetRuhsatiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaFaaliyetRuhsatiKonusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepoKullanimBelgeliFirma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepoKullanimBelgeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormuDolduraninAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemYonuBilgileriId = table.Column<int>(type: "int", nullable: false),
                    IslemTuruBilgileriId = table.Column<int>(type: "int", nullable: false),
                    IslemKonusuBilgileriId = table.Column<int>(type: "int", nullable: false),
                    SevkiyatSekliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenelBilgiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenelBilgiler_IslemKonusuBilgileri_IslemKonusuBilgileriId",
                        column: x => x.IslemKonusuBilgileriId,
                        principalTable: "IslemKonusuBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenelBilgiler_IslemTuruBilgileri_IslemTuruBilgileriId",
                        column: x => x.IslemTuruBilgileriId,
                        principalTable: "IslemTuruBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenelBilgiler_IslemYonuBilgileri_IslemYonuBilgileriId",
                        column: x => x.IslemYonuBilgileriId,
                        principalTable: "IslemYonuBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenelBilgiler_SevkiyatSekli_SevkiyatSekliId",
                        column: x => x.SevkiyatSekliId,
                        principalTable: "SevkiyatSekli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturalar",
                columns: table => new
                {
                    FaturaNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FaturaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeslimAdresiAdiTicaretUnvani = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KarsiFirmaBilgisiAdiUnvani = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaTeslimSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaturaParaBirimi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.FaturaNo);
                    table.ForeignKey(
                        name: "FK_Faturalar_KarsiFirmaBilgileri_KarsiFirmaBilgisiAdiUnvani",
                        column: x => x.KarsiFirmaBilgisiAdiUnvani,
                        principalTable: "KarsiFirmaBilgileri",
                        principalColumn: "AdiUnvani",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faturalar_TeslimAdresi_TeslimAdresiAdiTicaretUnvani",
                        column: x => x.TeslimAdresiAdiTicaretUnvani,
                        principalTable: "TeslimAdresi",
                        principalColumn: "AdiTicaretUnvani",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaNo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaturaBilgileri_Faturalar_FaturaNo",
                        column: x => x.FaturaNo,
                        principalTable: "Faturalar",
                        principalColumn: "FaturaNo");
                });

            migrationBuilder.CreateTable(
                name: "FonDekont",
                columns: table => new
                {
                    FonDekontDekontNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FonDekontTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonDekontTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FonDekontTutarPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonDekontKullanilan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FonDekontKullanilanPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonDekontKullanilanDolar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SBIFBilgileriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FonDekont", x => x.FonDekontDekontNo);
                });

            migrationBuilder.CreateTable(
                name: "SbifBilgiFisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FonDekontDekontNo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SbifBilgiFisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SbifBilgiFisi_FonDekont_FonDekontDekontNo",
                        column: x => x.FonDekontDekontNo,
                        principalTable: "FonDekont",
                        principalColumn: "FonDekontDekontNo");
                });

            migrationBuilder.CreateTable(
                name: "SBIFBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SbifGumrukBilgileriId = table.Column<int>(type: "int", nullable: true),
                    GenelBilgilerId = table.Column<int>(type: "int", nullable: false),
                    FaturaBilgileriId = table.Column<int>(type: "int", nullable: false),
                    MalKalemBilgileriId = table.Column<int>(type: "int", nullable: false),
                    TalepEdilenIsleticiHizmetleriId = table.Column<int>(type: "int", nullable: false),
                    SbifBilgiFisiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBIFBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_FaturaBilgileri_FaturaBilgileriId",
                        column: x => x.FaturaBilgileriId,
                        principalTable: "FaturaBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_GenelBilgiler_GenelBilgilerId",
                        column: x => x.GenelBilgilerId,
                        principalTable: "GenelBilgiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_MalKalemBilgileri_MalKalemBilgileriId",
                        column: x => x.MalKalemBilgileriId,
                        principalTable: "MalKalemBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_SbifBilgiFisi_SbifBilgiFisiId",
                        column: x => x.SbifBilgiFisiId,
                        principalTable: "SbifBilgiFisi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_TalepEdilenIsleticiHizmetleri_TalepEdilenIsleticiHizmetleriId",
                        column: x => x.TalepEdilenIsleticiHizmetleriId,
                        principalTable: "TalepEdilenIsleticiHizmetleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SBIFBilgileri_sbifGumrukBilgileri_SbifGumrukBilgileriId",
                        column: x => x.SbifGumrukBilgileriId,
                        principalTable: "sbifGumrukBilgileri",
                        principalColumn: "SbifGumrukBilgileriId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgileri_FaturaNo",
                table: "FaturaBilgileri",
                column: "FaturaNo");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_KarsiFirmaBilgisiAdiUnvani",
                table: "Faturalar",
                column: "KarsiFirmaBilgisiAdiUnvani");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_TeslimAdresiAdiTicaretUnvani",
                table: "Faturalar",
                column: "TeslimAdresiAdiTicaretUnvani");

            migrationBuilder.CreateIndex(
                name: "IX_FonDekont_SBIFBilgileriId",
                table: "FonDekont",
                column: "SBIFBilgileriId",
                unique: true,
                filter: "[SBIFBilgileriId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GenelBilgiler_IslemKonusuBilgileriId",
                table: "GenelBilgiler",
                column: "IslemKonusuBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_GenelBilgiler_IslemTuruBilgileriId",
                table: "GenelBilgiler",
                column: "IslemTuruBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_GenelBilgiler_IslemYonuBilgileriId",
                table: "GenelBilgiler",
                column: "IslemYonuBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_GenelBilgiler_SevkiyatSekliId",
                table: "GenelBilgiler",
                column: "SevkiyatSekliId");

            migrationBuilder.CreateIndex(
                name: "IX_MalKalemler_MalKalemBilgileriId",
                table: "MalKalemler",
                column: "MalKalemBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_FaturaBilgileriId",
                table: "SBIFBilgileri",
                column: "FaturaBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_GenelBilgilerId",
                table: "SBIFBilgileri",
                column: "GenelBilgilerId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_MalKalemBilgileriId",
                table: "SBIFBilgileri",
                column: "MalKalemBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_SbifBilgiFisiId",
                table: "SBIFBilgileri",
                column: "SbifBilgiFisiId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_SbifGumrukBilgileriId",
                table: "SBIFBilgileri",
                column: "SbifGumrukBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_SBIFBilgileri_TalepEdilenIsleticiHizmetleriId",
                table: "SBIFBilgileri",
                column: "TalepEdilenIsleticiHizmetleriId");

            migrationBuilder.CreateIndex(
                name: "IX_SbifBilgiFisi_FonDekontDekontNo",
                table: "SbifBilgiFisi",
                column: "FonDekontDekontNo");

            migrationBuilder.CreateIndex(
                name: "IX_sbifGumrukBilgileri_GumrukMudurluguOnayiId",
                table: "sbifGumrukBilgileri",
                column: "GumrukMudurluguOnayiId");

            migrationBuilder.CreateIndex(
                name: "IX_sbifGumrukBilgileri_GumrukMuhafazaMudurluguOnayiId",
                table: "sbifGumrukBilgileri",
                column: "GumrukMuhafazaMudurluguOnayiId");

            migrationBuilder.AddForeignKey(
                name: "FK_FonDekont_SBIFBilgileri_SBIFBilgileriId",
                table: "FonDekont",
                column: "SBIFBilgileriId",
                principalTable: "SBIFBilgileri",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaBilgileri_Faturalar_FaturaNo",
                table: "FaturaBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_FonDekont_SBIFBilgileri_SBIFBilgileriId",
                table: "FonDekont");

            migrationBuilder.DropTable(
                name: "MalKalemler");

            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "KarsiFirmaBilgileri");

            migrationBuilder.DropTable(
                name: "TeslimAdresi");

            migrationBuilder.DropTable(
                name: "SBIFBilgileri");

            migrationBuilder.DropTable(
                name: "FaturaBilgileri");

            migrationBuilder.DropTable(
                name: "GenelBilgiler");

            migrationBuilder.DropTable(
                name: "MalKalemBilgileri");

            migrationBuilder.DropTable(
                name: "SbifBilgiFisi");

            migrationBuilder.DropTable(
                name: "TalepEdilenIsleticiHizmetleri");

            migrationBuilder.DropTable(
                name: "sbifGumrukBilgileri");

            migrationBuilder.DropTable(
                name: "IslemKonusuBilgileri");

            migrationBuilder.DropTable(
                name: "IslemTuruBilgileri");

            migrationBuilder.DropTable(
                name: "IslemYonuBilgileri");

            migrationBuilder.DropTable(
                name: "SevkiyatSekli");

            migrationBuilder.DropTable(
                name: "FonDekont");

            migrationBuilder.DropTable(
                name: "gumrukMudurluguOnayi");

            migrationBuilder.DropTable(
                name: "gumrukMuhafazaMudurluguOnayi");
        }
    }
}
