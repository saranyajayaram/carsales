using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carsales.Migrations
{
    public partial class CdCarsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Carmodel", "Gearbox", "Mileage", "Modelyear", "Price", "Seats" },
                values: new object[,]
                {
                    { 2, "Ford", "Figo", "Automatic", 3000, 2010, 23000.0, 5 },
                    { 3, "BMW", "X1", "Automatic", 5000, 2009, 40000.0, 5 },
                    { 4, "Audi", "A3", "Automatic", 3000, 2005, 23000.0, 5 },
                    { 5, "Volvo", "v40", "Automatic", 3000, 2012, 50000.0, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
