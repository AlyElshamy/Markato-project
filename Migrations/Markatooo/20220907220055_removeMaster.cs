using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Markatooo.Migrations.Markatooo
{
    public partial class removeMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gateways",
                columns: table => new
                {
                    GateWayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    success_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    error_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantUdf1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantUdf2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantUdf3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantUdf4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantUdf5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantPaymentRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchReturnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchPayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantPaymentLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENCRP_KEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Testmode = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gateways", x => x.GateWayId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageModelId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amout = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GateWayId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    issuccess = table.Column<bool>(type: "bit", nullable: false),
                    payment_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TranID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchUdf1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchUdf2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchUdf3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchUdf4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchUdf5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resultIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    successIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentModelId);
                    table.ForeignKey(
                        name: "FK_Payments_Gateways_GateWayId",
                        column: x => x.GateWayId,
                        principalTable: "Gateways",
                        principalColumn: "GateWayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gateways",
                columns: new[] { "GateWayId", "ApiKey", "AuthUrl", "ENCRP_KEY", "MerchPayType", "MerchReturnUrl", "MerchantId", "MerchantPaymentLang", "MerchantPaymentRef", "MerchantUdf1", "MerchantUdf2", "MerchantUdf3", "MerchantUdf4", "MerchantUdf5", "Password", "ProductionURL", "TestURL", "Testmode", "Title", "UserName", "error_url", "success_url", "version" },
                values: new object[] { 2, null, "https://pgtest.cbk.com/ePay/api/cbk/online/pg/merchant/Authenticate", "6ePABf3mCkQeAKiTyT6GQTZtm_qdVwYxdPLBWbq_gL4ZVNRvTf1lO7iclmDAmGwNSGn5g4tUGotiWYzWzHArgoNEgRcu14Q-9iW7Lb08kpM1", null, "http://markatooo.beintrackpay.com/Response", null, "en", "test", null, null, null, null, null, "jFBm--OsYbQZTuVJgHao7QoFqllfUGSmCvl46CFedfU1", null, "https://pgtest.cbk.com/ePay/pg/epay?_v=", null, "CBK", "27387462", null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GateWayId",
                table: "Payments",
                column: "GateWayId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderNumber",
                table: "Payments",
                column: "OrderNumber",
                unique: true,
                filter: "[OrderNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Gateways");
        }
    }
}
