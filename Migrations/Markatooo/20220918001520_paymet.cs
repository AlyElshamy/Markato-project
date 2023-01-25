using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class paymet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "GateWayId", "ApiKey", "AuthUrl", "ENCRP_KEY", "MerchPayType", "MerchReturnUrl", "MerchantId", "MerchantPaymentLang", "MerchantPaymentRef", "MerchantUdf1", "MerchantUdf2", "MerchantUdf3", "MerchantUdf4", "MerchantUdf5", "Password", "ProductionURL", "TestURL", "Testmode", "Title", "UserName", "error_url", "success_url", "version" },
                values: new object[] { 2, null, "https://pgtest.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate", "FbwZvfx-xudBGOszQa-nkarUVel9jDSqm7MKZKoJ9KyybsEXb9hfiP7gaJ3--BSL78VK-k2rd6tTeISdpCnRu9gSlspqr0jU90C1h-k3yXs1", null, "http://markatooo.beintrackpay.com/Response", null, "en", "test", null, null, null, null, null, "-B76ERtLowiNGtH8fYTTU8yqkeAii9O99bP8lhD6xh81", null, "https://pgtest.cbk.com/ePay/pg/epay?_v=", null, "CBK", "27387462", null, null, null });
        }
    }
}
