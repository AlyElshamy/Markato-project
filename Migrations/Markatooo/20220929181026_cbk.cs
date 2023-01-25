using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class cbk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1,
                column: "Title",
                value: "MasterCard-NBK");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                columns: new[] { "AuthUrl", "ENCRP_KEY", "Password", "TestURL", "Title" },
                values: new object[] { "https://pg.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate", "FbwZvfx-xudBGOszQa-nkarUVel9jDSqm7MKZKoJ9KyybsEXb9hfiP7gaJ3--BSL78VK-k2rd6tTeISdpCnRu9gSlspqr0jU90C1h-k3yXs1", "B76ERtLowiNGtH8fYTTU8yqkeAii9O99bP8lhD6xh81", "https://pg.cbk.com/ePay/pg/epay?_v=", "KNET-CBK" });

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "Title",
                value: "MasterCard-CBK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 1,
                column: "Title",
                value: "NBK");

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 2,
                columns: new[] { "AuthUrl", "ENCRP_KEY", "Password", "TestURL", "Title" },
                values: new object[] { "https://pgtest.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate", "6ePABf3mCkQeAKiTyT6GQTZtm_qdVwYxdPLBWbq_gL4ZVNRvTf1lO7iclmDAmGwNSGn5g4tUGotiWYzWzHArgoNEgRcu14Q-9iW7Lb08kpM1", "jFBm--OsYbQZTuVJgHao7QoFqllfUGSmCvl46CFedfU1", "https://pgtest.cbk.com/ePay/pg/epay?_v=", "KNET" });

            migrationBuilder.UpdateData(
                table: "Gateways",
                keyColumn: "GateWayId",
                keyValue: 3,
                column: "Title",
                value: "MasterCard");
        }
    }
}
