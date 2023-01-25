﻿// <auto-generated />
using System;
using Markatooo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Markatooo.Migrations.Markatooo
{
    [DbContext(typeof(MarkatoooContext))]
    [Migration("20220915112909_cbkpayment")]
    partial class cbkpayment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Markatooo.Models.Gateway", b =>
                {
                    b.Property<int>("GateWayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENCRP_KEY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchPayType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchReturnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantPaymentLang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantPaymentRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantUdf1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantUdf2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantUdf3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantUdf4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantUdf5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Testmode")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("error_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("success_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GateWayId");

                    b.ToTable("Gateways");

                    b.HasData(
                        new
                        {
                            GateWayId = 2,
                            AuthUrl = "https://pgtest.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate",
                            ENCRP_KEY = "FbwZvfx-xudBGOszQa-nkarUVel9jDSqm7MKZKoJ9KyybsEXb9hfiP7gaJ3--BSL78VK-k2rd6tTeISdpCnRu9gSlspqr0jU90C1h-k3yXs1",
                            MerchReturnUrl = "http://markatooo.beintrackpay.com/Response",
                            MerchantPaymentLang = "en",
                            MerchantPaymentRef = "test",
                            Password = "-B76ERtLowiNGtH8fYTTU8yqkeAii9O99bP8lhD6xh81",
                            TestURL = "https://pgtest.cbk.com/ePay/pg/epay?_v=",
                            Title = "CBK",
                            UserName = "27387462"
                        });
                });

            modelBuilder.Entity("Markatooo.Models.LanguageModel", b =>
                {
                    b.Property<int>("LanguageModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageModelId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Markatooo.Models.PaymentModel", b =>
                {
                    b.Property<int>("PaymentModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Amout")
                        .HasColumnType("int");

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Auth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GateWayId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchUdf1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchUdf2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchUdf3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchUdf4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchUdf5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Userid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("issuccess")
                        .HasColumnType("bit");

                    b.Property<string>("payment_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resultIndicator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("successIndicator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentModelId");

                    b.HasIndex("GateWayId");

                    b.HasIndex("OrderNumber")
                        .IsUnique()
                        .HasFilter("[OrderNumber] IS NOT NULL");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Markatooo.Models.PaymentModel", b =>
                {
                    b.HasOne("Markatooo.Models.Gateway", "Gateway")
                        .WithMany()
                        .HasForeignKey("GateWayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gateway");
                });
#pragma warning restore 612, 618
        }
    }
}
