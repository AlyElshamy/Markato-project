using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "GateWayId", "ApiKey", "AuthUrl", "ENCRP_KEY", "Image", "MerchPayType", "MerchReturnUrl", "MerchantId", "MerchantPaymentLang", "MerchantPaymentRef", "MerchantUdf1", "MerchantUdf2", "MerchantUdf3", "MerchantUdf4", "MerchantUdf5", "Password", "ProductionURL", "TestURL", "Testmode", "Title", "UserName", "error_url", "isActive", "success_url", "version" },
                values: new object[] { 4, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "All", null, null, false, null, null });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusId", "Title" },
                values: new object[] { 5, "All" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusId",
                keyValue: 5);
        }
    }
}
