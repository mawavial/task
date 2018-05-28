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
    [Migration("20180528072533_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThreeAPIs.Models.CieloAPI", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditCardTransactionCollectionAmountCents");

                    b.Property<string>("CreditCardTransactionCollectionCreditCardCreditCardBrand");

                    b.Property<string>("CreditCardTransactionCollectionCreditCardCreditCardNumber");

                    b.Property<int>("CreditCardTransactionCollectionCreditCardExpMonth");

                    b.Property<int>("CreditCardTransactionCollectionCreditCardExpYear");

                    b.Property<string>("CreditCardTransactionCollectionCreditCardHolderName");

                    b.Property<int>("CreditCardTransactionCollectionCreditCardInstallmentCount");

                    b.Property<int>("CreditCardTransactionCollectionCreditCardSecurityCode");

                    b.Property<string>("Genre");

                    b.Property<Guid>("MerchantKey");

                    b.Property<string>("OrderOrderReference");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("CieloAPI");
                });
#pragma warning restore 612, 618
        }
    }
}