﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ThreeAPIs.Models;

namespace ThreeAPIs.Migrations
{
    [DbContext(typeof(ThreeAPIsContext))]
    partial class ThreeAPIsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThreeAPIs.Models.CieloAPI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CrediCardCardNumber")
                        .HasMaxLength(19);

                    b.Property<string>("CreditCardBrand")
                        .HasMaxLength(10);

                    b.Property<string>("CreditCardHolder")
                        .HasMaxLength(25);

                    b.Property<int>("CreditCardSecurityCode");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(255);

                    b.Property<string>("MechantKey")
                        .HasMaxLength(40);

                    b.Property<Guid>("MerchantId");

                    b.Property<string>("MerchantOrderId")
                        .HasMaxLength(50);

                    b.Property<int>("PaymentAmount");

                    b.Property<int>("PaymentInstallment");

                    b.Property<int>("PaymentSoftDescriptor")
                        .HasMaxLength(13);

                    b.Property<string>("PaymentType")
                        .HasMaxLength(100);

                    b.Property<Guid>("RequestId");

                    b.HasKey("ID");

                    b.ToTable("CieloAPI");
                });

            modelBuilder.Entity("ThreeAPIs.Models.ClearSecuAPI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnalysisLocation");

                    b.Property<string>("ApiKey");

                    b.Property<string>("LoginToken");

                    b.HasKey("ID");

                    b.ToTable("ClearSecuAPI");
                });

            modelBuilder.Entity("ThreeAPIs.Models.StoneAPI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditCardTransactionCollectionAmountCents");

                    b.Property<string>("CreditCardTransactionCollectionCreditCardCreditCardBrand")
                        .HasMaxLength(10);

                    b.Property<string>("CreditCardTransactionCollectionCreditCardCreditCardNumber")
                        .HasMaxLength(19);

                    b.Property<int>("CreditCardTransactionCollectionCreditCardExpMonth")
                        .HasMaxLength(2);

                    b.Property<int>("CreditCardTransactionCollectionCreditCardExpYear");

                    b.Property<string>("CreditCardTransactionCollectionCreditCardHolderName")
                        .HasMaxLength(25);

                    b.Property<int>("CreditCardTransactionCollectionCreditCardInstallmentCount");

                    b.Property<int>("CreditCardTransactionCollectionCreditCardSecurityCode");

                    b.Property<Guid>("MerchantKey");

                    b.Property<string>("OrderOrderReference");

                    b.HasKey("ID");

                    b.ToTable("StoneAPI");
                });
#pragma warning restore 612, 618
        }
    }
}
