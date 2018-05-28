using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThreeAPIs.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CieloAPI",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCardTransactionCollectionAmountCents = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardCreditCardBrand = table.Column<string>(nullable: true),
                    CreditCardTransactionCollectionCreditCardCreditCardNumber = table.Column<string>(nullable: true),
                    CreditCardTransactionCollectionCreditCardExpMonth = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardExpYear = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardHolderName = table.Column<string>(nullable: true),
                    CreditCardTransactionCollectionCreditCardInstallmentCount = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardSecurityCode = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MerchantKey = table.Column<Guid>(nullable: false),
                    OrderOrderReference = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CieloAPI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CieloAPI");
        }
    }
}
