﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hryhoriichuk.University.Instagram.Web.Migrations
{
    /// <inheritdoc />
    public partial class FollowTabless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FollowDate",
                table: "Follows",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Follows",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Follows");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FollowDate",
                table: "Follows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
