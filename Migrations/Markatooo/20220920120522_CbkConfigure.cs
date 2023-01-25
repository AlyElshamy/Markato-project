using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class CbkConfigure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "GateWayId", "ApiKey", "AuthUrl", "ENCRP_KEY", "MerchPayType", "MerchReturnUrl", "MerchantId", "MerchantPaymentLang", "MerchantPaymentRef", "MerchantUdf1", "MerchantUdf2", "MerchantUdf3", "MerchantUdf4", "MerchantUdf5", "Password", "ProductionURL", "TestURL", "Testmode", "Title", "UserName", "error_url", "success_url", "version" },
                values: new object[] { 2, null, "https://pgtest.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate", "6ePABf3mCkQeAKiTyT6GQTZtm_qdVwYxdPLBWbq_gL4ZVNRvTf1lO7iclmDAmGwNSGn5g4tUGotiWYzWzHArgoNEgRcu14Q-9iW7Lb08kpM1", null, "https://markatooo.beintrackpay.com/Response", null, "en", "test", null, null, null, null, null, "jFBm--OsYbQZTuVJgHao7QoFqllfUGSmCvl46CFedfU1", null, "https://pgtest.cbk.com/ePay/pg/epay?_v=", null, "KNET", "27387462", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2);
        }
    }
}
