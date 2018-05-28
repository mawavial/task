using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ThreeAPIs.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCardTransactionCollectionAmountCents",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardTransactionCollectionCreditCardCreditCardBrand",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardTransactionCollectionCreditCardCreditCardNumber",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardTransactionCollectionCreditCardExpMonth",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardTransactionCollectionCreditCardHolderName",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "OrderOrderReference",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CieloAPI");

            migrationBuilder.RenameColumn(
                name: "MerchantKey",
                table: "CieloAPI",
                newName: "RequestId");

            migrationBuilder.RenameColumn(
                name: "CreditCardTransactionCollectionCreditCardSecurityCode",
                table: "CieloAPI",
                newName: "PaymentInstallment");

            migrationBuilder.RenameColumn(
                name: "CreditCardTransactionCollectionCreditCardInstallmentCount",
                table: "CieloAPI",
                newName: "PaymentAmount");

            migrationBuilder.RenameColumn(
                name: "CreditCardTransactionCollectionCreditCardExpYear",
                table: "CieloAPI",
                newName: "CreditCardSecurityCode");

            migrationBuilder.AddColumn<string>(
                name: "CrediCardCardNumber",
                table: "CieloAPI",
                maxLength: 19,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardBrand",
                table: "CieloAPI",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardHolder",
                table: "CieloAPI",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "CieloAPI",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MechantKey",
                table: "CieloAPI",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MerchantId",
                table: "CieloAPI",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MerchantOrderId",
                table: "CieloAPI",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentSoftDescriptor",
                table: "CieloAPI",
                maxLength: 13,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "CieloAPI",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClearSecuAPI",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnalysisLocation = table.Column<string>(nullable: true),
                    ApiKey = table.Column<string>(nullable: true),
                    LoginToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClearSecuAPI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StoneAPI",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCardTransactionCollectionAmountCents = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardCreditCardBrand = table.Column<string>(maxLength: 10, nullable: true),
                    CreditCardTransactionCollectionCreditCardCreditCardNumber = table.Column<string>(maxLength: 19, nullable: true),
                    CreditCardTransactionCollectionCreditCardExpMonth = table.Column<int>(maxLength: 2, nullable: false),
                    CreditCardTransactionCollectionCreditCardExpYear = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardHolderName = table.Column<string>(maxLength: 25, nullable: true),
                    CreditCardTransactionCollectionCreditCardInstallmentCount = table.Column<int>(nullable: false),
                    CreditCardTransactionCollectionCreditCardSecurityCode = table.Column<int>(nullable: false),
                    MerchantKey = table.Column<Guid>(nullable: false),
                    OrderOrderReference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneAPI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClearSecuAPI");

            migrationBuilder.DropTable(
                name: "StoneAPI");

            migrationBuilder.DropColumn(
                name: "CrediCardCardNumber",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardBrand",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CreditCardHolder",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "MechantKey",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "MerchantOrderId",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "PaymentSoftDescriptor",
                table: "CieloAPI");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "CieloAPI");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "CieloAPI",
                newName: "MerchantKey");

            migrationBuilder.RenameColumn(
                name: "PaymentInstallment",
                table: "CieloAPI",
                newName: "CreditCardTransactionCollectionCreditCardSecurityCode");

            migrationBuilder.RenameColumn(
                name: "PaymentAmount",
                table: "CieloAPI",
                newName: "CreditCardTransactionCollectionCreditCardInstallmentCount");

            migrationBuilder.RenameColumn(
                name: "CreditCardSecurityCode",
                table: "CieloAPI",
                newName: "CreditCardTransactionCollectionCreditCardExpYear");

            migrationBuilder.AddColumn<int>(
                name: "CreditCardTransactionCollectionAmountCents",
                table: "CieloAPI",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardTransactionCollectionCreditCardCreditCardBrand",
                table: "CieloAPI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardTransactionCollectionCreditCardCreditCardNumber",
                table: "CieloAPI",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreditCardTransactionCollectionCreditCardExpMonth",
                table: "CieloAPI",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreditCardTransactionCollectionCreditCardHolderName",
                table: "CieloAPI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "CieloAPI",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderOrderReference",
                table: "CieloAPI",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CieloAPI",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "CieloAPI",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CieloAPI",
                nullable: true);
        }
    }
}
