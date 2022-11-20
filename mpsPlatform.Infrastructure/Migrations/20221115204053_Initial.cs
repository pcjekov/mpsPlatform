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
                name: "Мanifacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Мanifacturers", x => x.Id);
                });

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
                name: "DatesOfEntrys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatesOfEntrys", x => x.Id);
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
                name: "ЕquipmentModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MaxPaperType = table.Column<int>(type: "int", nullable: false),
                    EquimpentType = table.Column<int>(type: "int", nullable: false),
                    МanifacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ЕquipmentModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ЕquipmentModels_Мanifacturers_МanifacturerId",
                        column: x => x.МanifacturerId,
                        principalTable: "Мanifacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ЕquipmentLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ЕquipmentLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ЕquipmentLocations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
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
                name: "EquimpentSerialNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ЕquipmentModelId = table.Column<int>(type: "int", nullable: false),
                    ЕquipmentLocationId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    PriceMonochromeA4 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceColorA4 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceMonochromeA3 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false),
                    PriceColorA3 = table.Column<decimal>(type: "decimal(10,8)", precision: 10, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquimpentSerialNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquimpentSerialNumbers_ЕquipmentLocations_ЕquipmentLocationId",
                        column: x => x.ЕquipmentLocationId,
                        principalTable: "ЕquipmentLocations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EquimpentSerialNumbers_ЕquipmentModels_ЕquipmentModelId",
                        column: x => x.ЕquipmentModelId,
                        principalTable: "ЕquipmentModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EquimpentSerialNumbers_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountersColorA3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCounter = table.Column<int>(type: "int", nullable: false),
                    EquimpentSerialNumberId = table.Column<int>(type: "int", nullable: false),
                    DateOfEntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountersColorA3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountersColorA3_DatesOfEntrys_DateOfEntryId",
                        column: x => x.DateOfEntryId,
                        principalTable: "DatesOfEntrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountersColorA3_EquimpentSerialNumbers_EquimpentSerialNumberId",
                        column: x => x.EquimpentSerialNumberId,
                        principalTable: "EquimpentSerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountersColorA4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCounter = table.Column<int>(type: "int", nullable: false),
                    EquimpentSerialNumberId = table.Column<int>(type: "int", nullable: false),
                    DateOfEntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountersColorA4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountersColorA4_DatesOfEntrys_DateOfEntryId",
                        column: x => x.DateOfEntryId,
                        principalTable: "DatesOfEntrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountersColorA4_EquimpentSerialNumbers_EquimpentSerialNumberId",
                        column: x => x.EquimpentSerialNumberId,
                        principalTable: "EquimpentSerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountersMonochromeA3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCounter = table.Column<int>(type: "int", nullable: false),
                    EquimpentSerialNumberId = table.Column<int>(type: "int", nullable: false),
                    DateOfEntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountersMonochromeA3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountersMonochromeA3_DatesOfEntrys_DateOfEntryId",
                        column: x => x.DateOfEntryId,
                        principalTable: "DatesOfEntrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountersMonochromeA3_EquimpentSerialNumbers_EquimpentSerialNumberId",
                        column: x => x.EquimpentSerialNumberId,
                        principalTable: "EquimpentSerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountersMonochromeA4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCounter = table.Column<int>(type: "int", nullable: false),
                    EquimpentSerialNumberId = table.Column<int>(type: "int", nullable: false),
                    DateOfEntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountersMonochromeA4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountersMonochromeA4_DatesOfEntrys_DateOfEntryId",
                        column: x => x.DateOfEntryId,
                        principalTable: "DatesOfEntrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountersMonochromeA4_EquimpentSerialNumbers_EquimpentSerialNumberId",
                        column: x => x.EquimpentSerialNumberId,
                        principalTable: "EquimpentSerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "5cbac67a-d789-479c-8368-9e878a4c4c7f", "admin@mpsPlatform.com", false, false, null, "admin@mpsplatform.com", "admin@mpsplatform.com", "AQAAAAEAACcQAAAAECg1FoRAyl6PL6FCheDcsaMUWSfYESVGq39aTG6cy8G7q4dP9Vy7ZJvkve82eCChCg==", null, false, "0b3dec3a-369b-4d6a-88de-2ad76293e715", false, "admin@mpsPlatform.com" });

            migrationBuilder.CreateIndex(
                name: "IX_ЕquipmentLocations_CustomerId",
                table: "ЕquipmentLocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ЕquipmentModels_МanifacturerId",
                table: "ЕquipmentModels",
                column: "МanifacturerId");

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
                name: "IX_CountersColorA3_DateOfEntryId",
                table: "CountersColorA3",
                column: "DateOfEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersColorA3_EquimpentSerialNumberId",
                table: "CountersColorA3",
                column: "EquimpentSerialNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersColorA4_DateOfEntryId",
                table: "CountersColorA4",
                column: "DateOfEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersColorA4_EquimpentSerialNumberId",
                table: "CountersColorA4",
                column: "EquimpentSerialNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersMonochromeA3_DateOfEntryId",
                table: "CountersMonochromeA3",
                column: "DateOfEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersMonochromeA3_EquimpentSerialNumberId",
                table: "CountersMonochromeA3",
                column: "EquimpentSerialNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersMonochromeA4_DateOfEntryId",
                table: "CountersMonochromeA4",
                column: "DateOfEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountersMonochromeA4_EquimpentSerialNumberId",
                table: "CountersMonochromeA4",
                column: "EquimpentSerialNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_EquimpentSerialNumbers_ЕquipmentLocationId",
                table: "EquimpentSerialNumbers",
                column: "ЕquipmentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EquimpentSerialNumbers_ЕquipmentModelId",
                table: "EquimpentSerialNumbers",
                column: "ЕquipmentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EquimpentSerialNumbers_ContractId",
                table: "EquimpentSerialNumbers",
                column: "ContractId");

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
                name: "CountersColorA3");

            migrationBuilder.DropTable(
                name: "CountersColorA4");

            migrationBuilder.DropTable(
                name: "CountersMonochromeA3");

            migrationBuilder.DropTable(
                name: "CountersMonochromeA4");

            migrationBuilder.DropTable(
                name: "InstallersPeople");

            migrationBuilder.DropTable(
                name: "SparePartsModels");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DatesOfEntrys");

            migrationBuilder.DropTable(
                name: "EquimpentSerialNumbers");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "ЕquipmentLocations");

            migrationBuilder.DropTable(
                name: "ЕquipmentModels");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Мanifacturers");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
