using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    FileData = table.Column<byte[]>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    UploadDate = table.Column<DateTime>(nullable: false),
                    DocumentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PersonalMail = table.Column<string>(nullable: false),
                    CorpMail = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    DOJ = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Role = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    OTP = table.Column<int>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TaskAssigned",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TaskStatus = table.Column<bool>(nullable: false),
                    Scores = table.Column<int>(nullable: false),
                    DocumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAssigned", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_TaskAssigned_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAssigned_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssigned_DocumentId",
                table: "TaskAssigned",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssigned_UserId",
                table: "TaskAssigned",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskAssigned");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
