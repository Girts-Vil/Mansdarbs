using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VagnersStore.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "German made cars", "german cars" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "book", "Britain made cars", "england cars" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "book", "American made cars", "american cars" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 25, 14, 58, 24, 918, DateTimeKind.Local).AddTicks(6134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Merceds Benz CLS 55 AMG 2005. gada ar dzinēju V8 5.0, kuram ir 225 kW (302 HP), nobraukums sastāda 202 000 km", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/2006-Mercedes-Benz-CLS55-AMG-2.jpg/320px-2006-Mercedes-Benz-CLS55-AMG-2.jpg", false, false, 23.750m, 25.000m, "Mercedes-Benz CLS55 AMG" },
                    { 2, 1, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5285), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās BMW 3 series G20 2019. gada ar bendzīna dzinēju I6 3.0, kuram ir 185 kW (248 HP), nobraukums sastāda 100 000 km", "https://upload.wikimedia.org/wikipedia/commons/8/8d/BMW_G20_IMG_0167.jpg", false, false, 32.000m, 35.000m, "BMW 3 series G20" },
                    { 3, 1, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5346), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Audi e-tron 55 2018. gada ar elektrodzinēju, kuram ir 125 kW (168 HP), nobraukums sastāda 65 000 km", "https://upload.wikimedia.org/wikipedia/commons/6/6a/Audi_e-tron_Sportback_Genf_2019_1Y7A5437.jpg", false, false, 49.750m, 50.000m, "Audi e-tron" },
                    { 4, 2, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Range Rover Sport SVR 2018. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 165 000 km", "https://upload.wikimedia.org/wikipedia/commons/8/8d/Range_Rover_Sport_SVR%2C_IAA_2017%2C_Frankfurt_%281Y7A3071%29.jpg", false, false, 69.500m, 70.000m, "Range Rover Sport SVR" },
                    { 5, 2, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5364), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Jaguar F-Type 2019. gada ar dzinēju V8 5.0, kuram ir 431 kW (585 HP), nobraukums sastāda 162 000 km", "https://upload.wikimedia.org/wikipedia/commons/6/64/Jaguar_F-Type_R%2C_TWB_18%2C_Friedrichshafen_%28OW1A0263%29.jpg", false, false, 53.000m, 55.000m, "Jaguar F-Type" },
                    { 6, 2, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Rolls-Royce Phantom 2020. gada ar dzinēju V12 6.75, kuram ir 420 kW (563 HP), nobraukums sastāda 35 000 km", "https://upload.wikimedia.org/wikipedia/commons/a/aa/Rolls-Royce_Phantom%2C_Geneva_International_Motor_Show_2018%2C_Le_Grand-Saconnex_%281X7A1220%29.jpg", false, false, 400.000m, 402.000m, "Rolls-Royce Phantom" },
                    { 7, 3, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Dodge Challenger SRT Demon 2020. gada ar dzinēju V8 6.2, kuram ir 712 kW (800 HP), nobraukums sastāda 95 000 km", "https://upload.wikimedia.org/wikipedia/commons/7/79/Dodge_Challenger_SRT_Hellcat_2015-20180909-RM-171851.jpg", false, false, 72.500m, 73.000m, "Dodge Challenger SRT Demon" },
                    { 8, 3, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Chevrolet Camaro 2017. gada ar dzinēju V8 5.4, kuram ir 485 kW (650 HP), nobraukums sastāda 102 000 km", "https://upload.wikimedia.org/wikipedia/commons/f/f6/Chevrolet_Camaro_RS_%285th_gen%29%2C_2015_model%2C_Wien_26_July_2020_JM_%284%29.jpg", false, false, 51.000m, 53.000m, "Chevrolet Camaro" },
                    { 9, 3, new DateTime(2021, 4, 25, 14, 58, 24, 922, DateTimeKind.Local).AddTicks(5384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pārdodās Ford Mustang 2019. gada ar dzinēju V8 5.0, kuram ir 380 kW (435 HP), nobraukums sastāda 115 000 km", "https://upload.wikimedia.org/wikipedia/commons/f/f3/Ford_Mustang_VI_Bullit%2C_GIMS_2018%2C_Le_Grand-Saconnex_%281X7A1282%29.jpg", false, false, 44.750m, 45.000m, "Ford Mustang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
