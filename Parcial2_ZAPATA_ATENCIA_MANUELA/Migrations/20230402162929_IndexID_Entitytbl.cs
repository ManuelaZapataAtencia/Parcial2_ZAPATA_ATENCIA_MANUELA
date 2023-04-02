using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.Migrations
{
    /// <inheritdoc />
    public partial class IndexID_Entitytbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConcertsDBs",
                table: "ConcertsDBs");

            migrationBuilder.RenameTable(
                name: "ConcertsDBs",
                newName: "Entity");

            migrationBuilder.AlterColumn<bool>(
                name: "IsUsed",
                table: "Entity",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Entity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entity",
                table: "Entity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Id",
                table: "Entity",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entity",
                table: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Entity_Id",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Entity");

            migrationBuilder.RenameTable(
                name: "Entity",
                newName: "ConcertsDBs");

            migrationBuilder.AlterColumn<bool>(
                name: "IsUsed",
                table: "ConcertsDBs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConcertsDBs",
                table: "ConcertsDBs",
                column: "Id");
        }
    }
}
