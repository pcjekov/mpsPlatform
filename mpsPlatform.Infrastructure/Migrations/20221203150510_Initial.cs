using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mpsPlatform.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallersPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallersPeople", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Resource = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquimpentLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ЕquipmentModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MaxPaperType = table.Column<int>(type: "int", nullable: false),
                    EquimpentType = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ЕquipmentModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ЕquipmentModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerialNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ЕquipmentSerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ЕquipmentModelId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    PriceMonochromeA4 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceColorA4 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceMonochromeA3 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceColorA3 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerialNumbers_ЕquipmentModels_ЕquipmentModelId",
                        column: x => x.ЕquipmentModelId,
                        principalTable: "ЕquipmentModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SerialNumbers_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerialNumbers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SparePartsModels",
                columns: table => new
                {
                    SparePartId = table.Column<int>(type: "int", nullable: false),
                    ЕquipmentModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartsModels", x => new { x.SparePartId, x.ЕquipmentModelId });
                    table.ForeignKey(
                        name: "FK_SparePartsModels_ЕquipmentModels_ЕquipmentModelId",
                        column: x => x.ЕquipmentModelId,
                        principalTable: "ЕquipmentModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SparePartsModels_SpareParts_SparePartId",
                        column: x => x.SparePartId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonochromeA4 = table.Column<int>(type: "int", nullable: false),
                    MonochromeA3 = table.Column<int>(type: "int", nullable: false),
                    ColorA4 = table.Column<int>(type: "int", nullable: false),
                    ColorA3 = table.Column<int>(type: "int", nullable: false),
                    DateOfCounter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SerialNumberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counters_SerialNumbers_SerialNumberId",
                        column: x => x.SerialNumberId,
                        principalTable: "SerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "740560d3-c595-4fb8-8bcc-d1623c07fcf0", "admin@mpsPlatform.com", false, false, null, "admin@mpsplatform.com", "ADMIN", "AQAAAAEAACcQAAAAENtI4RTB6BbhZ0usbNXhTyO4qv44tclvnsyIHQMtNVpSQ/kfRMMsMaTmf7r/TsYv0w==", null, false, "216cb4ba-d031-4ac7-87a2-2bfb3a84f1ac", false, "admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Metal Construct PLC" },
                    { 2, "Ring Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Xerox" },
                    { 2, "HP" }
                });

            migrationBuilder.InsertData(
                table: "SpareParts",
                columns: new[] { "Id", "Name", "PartNumber", "Resource" },
                values: new object[,]
                {
                    { 1, "cartridge", "CF237YC", 37000 },
                    { 2, "Maintenance Kit", "L0H25A", 225000 },
                    { 3, "black cartridge", "006R01701", 26000 },
                    { 4, "cyan cartridge", "006R01702", 15000 },
                    { 5, "magenta cartridge", "006R01703", 15000 },
                    { 6, "yellow cartridge", "006R01704", 15000 },
                    { 7, "drum", "013R00662", 126000 },
                    { 8, "black cartridge", "006R01758", 59000 },
                    { 9, "cyan cartridge", "006R01759", 28000 },
                    { 10, "magenta cartridge", "006R01760", 28000 },
                    { 11, "yellow cartridge", "006R01761", 28000 },
                    { 12, "drum", "013R00681", 180000 },
                    { 13, "cartridge", "106R03585", 37000 },
                    { 14, "drum", "101R00554", 24000 }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "Id", "ContractNumber", "CustomerId" },
                values: new object[,]
                {
                    { 1, "CTR-003263/ 2022", 2 },
                    { 2, "CTR-004452/ 2021", 1 },
                    { 3, "CTR-002526/ 2019", 2 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CustomerId", "EquimpentLocation" },
                values: new object[,]
                {
                    { 1, 2, "Managers" },
                    { 2, 2, "PPR" },
                    { 3, 2, "Med.center" },
                    { 4, 2, "Capture" },
                    { 5, 2, "Handwork" },
                    { 6, 1, "Админ.сграда ет.1" }
                });

            migrationBuilder.InsertData(
                table: "ЕquipmentModels",
                columns: new[] { "Id", "EquimpentType", "ImageUrl", "ManufacturerId", "MaxPaperType", "Name", "PartNumber" },
                values: new object[,]
                {
                    { 1, 0, null, 1, 0, "VersaLink B610dn", "B610V_DN" },
                    { 2, 0, null, 1, 0, "VersaLink B405", "B405V_DN" },
                    { 3, 1, null, 1, 1, "AltaLink C8035", "C8001V_T_097S04830" },
                    { 4, 1, null, 1, 1, "AltaLink C8155", "C8102V_F_097S05045" },
                    { 5, 0, null, 2, 0, "LaserJet M609dn", "K0Q21A" },
                    { 6, 0, null, 1, 0, "VersaLink B605", "B605V_DN" }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "ContractId", "LocationId", "PriceColorA3", "PriceColorA4", "PriceMonochromeA3", "PriceMonochromeA4", "ЕquipmentModelId", "ЕquipmentSerialNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, 0.1722m, 0.0818m, 0.00216m, 0.00108m, 3, "3717622919" },
                    { 2, 1, 2, 0.1722m, 0.0818m, 0.00216m, 0.00108m, 4, "3774403743" },
                    { 3, 1, 3, 0m, 0m, 0m, 0.0189m, 2, "3719467309" },
                    { 4, 3, 4, 0m, 0m, 0m, 0.02m, 5, "CNBVK9317X" },
                    { 5, 3, 6, 0m, 0m, 0m, 0.02m, 1, "3394734267" },
                    { 6, 2, 6, 0m, 0m, 0m, 0.018m, 6, "3394976619" }
                });

            migrationBuilder.InsertData(
                table: "SparePartsModels",
                columns: new[] { "SparePartId", "ЕquipmentModelId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 4 },
                    { 9, 4 },
                    { 10, 4 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 2 },
                    { 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "Id", "ColorA3", "ColorA4", "DateOfCounter", "MonochromeA3", "MonochromeA4", "SerialNumberId" },
                values: new object[,]
                {
                    { 1, 4670, 336300, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 900, 95000, 1 },
                    { 2, 390, 35800, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4700, 2 },
                    { 3, 0, 0, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 58400, 3 },
                    { 4, 0, 0, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 94700, 4 },
                    { 5, 0, 0, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 232100, 5 },
                    { 6, 0, 0, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 137200, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ЕquipmentModels_ManufacturerId",
                table: "ЕquipmentModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CustomerId",
                table: "Contract",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Counters_SerialNumberId",
                table: "Counters",
                column: "SerialNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CustomerId",
                table: "Locations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SerialNumbers_ЕquipmentModelId",
                table: "SerialNumbers",
                column: "ЕquipmentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SerialNumbers_ContractId",
                table: "SerialNumbers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_SerialNumbers_LocationId",
                table: "SerialNumbers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SparePartsModels_ЕquipmentModelId",
                table: "SparePartsModels",
                column: "ЕquipmentModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "InstallersPeople");

            migrationBuilder.DropTable(
                name: "SparePartsModels");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "ЕquipmentModels");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
