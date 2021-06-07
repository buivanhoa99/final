using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenKhach = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhach);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSachs",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSachs", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sachs_LoaiSachs_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSachs",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    MaKhach = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => new { x.MaKhach, x.MaSach });
                    table.ForeignKey(
                        name: "FK_DonHangs_KhachHangs_MaKhach",
                        column: x => x.MaKhach,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangs_Sachs_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sachs",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "MaKhach", "TenDN", "TenKhach" },
                values: new object[,]
                {
                    { 1, "DN1", "Không Gia Đình" },
                    { 2, "DN2", "Một món quà" },
                    { 3, "DN3", "Tam quốc diễn nghĩa" }
                });

            migrationBuilder.InsertData(
                table: "LoaiSachs",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { 1, "Trinh Thám" },
                    { 2, "Hài Hước" },
                    { 3, "Self-help" }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "DonGia", "Hinh", "MaLoai", "Mota", "TenSach" },
                values: new object[] { 1, 200000, "https://vtv1.mediacdn.vn/thumb_w/650/2019/9/3/17988102-7420621-the8bookpotterseriesandotherrelatedstoriesaudiorecordi-a-61567460030727-15674958768921527956477.jpg", 1, "Harry Potter Full", "Harry Potter" });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "DonGia", "Hinh", "MaLoai", "Mota", "TenSach" },
                values: new object[] { 2, 350000, "https://dep.com.vn/wp-content/uploads/2018/11/khong-gia-dinh-1.jpg", 2, "Sách 1st seller", "Không Gia Đình" });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "MaKhach", "MaSach", "SoLuong" },
                values: new object[] { 2, 1, 10 });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "MaKhach", "MaSach", "SoLuong" },
                values: new object[] { 1, 2, 20 });

            migrationBuilder.InsertData(
                table: "DonHangs",
                columns: new[] { "MaKhach", "MaSach", "SoLuong" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_MaSach",
                table: "DonHangs",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_MaLoai",
                table: "Sachs",
                column: "MaLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "LoaiSachs");
        }
    }
}
