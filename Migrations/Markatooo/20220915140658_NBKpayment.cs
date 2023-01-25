using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class NBKpayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "version",
                value: "65");

            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "GateWayId", "ApiKey", "AuthUrl", "ENCRP_KEY", "MerchPayType", "MerchReturnUrl", "MerchantId", "MerchantPaymentLang", "MerchantPaymentRef", "MerchantUdf1", "MerchantUdf2", "MerchantUdf3", "MerchantUdf4", "MerchantUdf5", "Password", "ProductionURL", "TestURL", "Testmode", "Title", "UserName", "error_url", "success_url", "version" },
                values: new object[] { 1, null, null, null, null, null, "900185001", null, null, null, null, null, null, null, "937cd5c82ab0949b7afad77cd8958122", null, "https://nbkpayment.gateway.mastercard.com/api/rest", null, "NBK", "merchant.900185001", null, null, "65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "version",
                value: "67");
        }
    }
}
