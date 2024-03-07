using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "specialTag" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Fusc thdfnfnosnos sjnsodfn ,sdfnsodnonsf ,sfnsofninwofninsf", "https://images.pexels.com/photos/2059151/pexels-photo-2059151.jpeg?auto=compress&cs=tinysrgb&w=400", "Spring Roll", 7.9900000000000002, "" },
                    { 2, "Appetizer", "iscnnosdincvo sovnsdionvsdonv kxviovnsiondvosnvio", "https://images.pexels.com/photos/8272528/pexels-photo-8272528.jpeg?auto=compress&cs=tinysrgb&w=400", "MeatPie ", 500.0, "" },
                    { 3, "Appetizer", "jscnsovnsovns sdcvnsiodvnsov osvnosivnsdiovnosdv", "https://images.pexels.com/photos/3253735/pexels-photo-3253735.jpeg?auto=compress&cs=tinysrgb&w=400", "Doughnut", 300.0, "" },
                    { 4, "Appetizer", "jdsjcnsdocu  scmciamasimeimfoiw iowdweodeowdoed", "https://images.pexels.com/photos/5900509/pexels-photo-5900509.jpeg?auto=compress&cs=tinysrgb&w=400", "Fish Pie", 250.0, "" },
                    { 5, "Appetizer", "sjdcjscnsci koscmscoisdc iscmosdicsmdm ", "https://images.pexels.com/photos/1211887/pexels-photo-1211887.jpeg?auto=compress&cs=tinysrgb&w=400", "Salad", 203.0, "" },
                    { 6, "Food", "opowiqmdpm piemd0mim eimdwpedmoif", "https://images.pexels.com/photos/1583884/pexels-photo-1583884.jpeg?auto=compress&cs=tinysrgb&w=400", "Chips", 100.0, "" },
                    { 7, "Food", "sdjsicscj cmsdjcnsucnsc c ", "https://images.pexels.com/photos/1775043/pexels-photo-1775043.jpeg?auto=compress&cs=tinysrgb&w=400", "Bread", 300.0, "" },
                    { 8, "Drink", " lorem ipsdum scnuanoadnap", "https://images.pexels.com/photos/50593/coca-cola-cold-drink-soft-drink-coke-50593.jpeg?auto=compress&cs=tinysrgb&w=400", "Coke", 250.0, "" },
                    { 9, "Drink", "jhsodd scmdciocwiec dcnocweic", "https://images.pexels.com/photos/13950097/pexels-photo-13950097.jpeg?auto=compress&cs=tinysrgb&w=400", "Fanta", 250.0, "" },
                    { 10, "Food", "cjskcnsjcdnowucn naodiadocm jnodnondiqnd jdqdiodnqodnqcqwk", "https://images.pexels.com/photos/6066056/pexels-photo-6066056.jpeg?auto=compress&cs=tinysrgb&w=400", "Jollof rice", 1500.0, "" },
                    { 11, "Food", "poewerid idemdwei diamasism", "https://images.pexels.com/photos/6937455/pexels-photo-6937455.jpeg?auto=compress&cs=tinysrgb&w=400", "Fried rice", 430.0, "" },
                    { 12, "Snacks", "xsdcwefo cwcmiwocpxadp pspocmsdomcsdoicmpo scspocsdcpocspmi", "https://images.pexels.com/photos/1055272/pexels-photo-1055272.jpeg?auto=compress&cs=tinysrgb&w=400", "Cake", 7.9900000000000002, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
