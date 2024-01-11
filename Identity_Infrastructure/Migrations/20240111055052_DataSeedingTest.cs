﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity_Infrastructure.Migrations
{
    public partial class DataSeedingTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClaimIdentity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Identity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Claim",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 6,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 7,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 8,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 9,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 11,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 12,
                column: "RolesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 13,
                column: "RolesId",
                value: 1);

            migrationBuilder.InsertData(
                table: "ClaimRole",
                columns: new[] { "Id", "ClaimsId", "RolesId" },
                values: new object[] { 10, 10, 1 });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdentitiesId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Claim",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ReadClaims" },
                    { 2, "WriteClaim" },
                    { 3, "ChangeClaim" },
                    { 4, "DeleteClaim" },
                    { 5, "ReadRoles" },
                    { 6, "WriteRole" },
                    { 7, "ChangeRole" },
                    { 8, "DeleteRole" },
                    { 9, "ReadIdentities" },
                    { 10, "ReadOwnIdentity" },
                    { 11, "WriteIdentity" },
                    { 12, "ChangeIdentity" },
                    { 13, "DeleteIdentity" }
                });

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 6,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 7,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 8,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 9,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 11,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 12,
                column: "RolesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ClaimRole",
                keyColumn: "Id",
                keyValue: 13,
                column: "RolesId",
                value: null);

            migrationBuilder.InsertData(
                table: "Identity",
                columns: new[] { "Id", "Email", "LastLogin", "LastLogout", "PasswordHash", "PasswordSalt", "RegistrationDate", "Username" },
                values: new object[] { 1, "eduplatform@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0n2D6RfevH0iAO2odcm6QcsXPxSnTQMeT1VaCpVZ4qc=", "GWJHabKuRfxzdRAMvdjGxQ==", new DateTime(2024, 1, 11, 4, 23, 43, 492, DateTimeKind.Unspecified).AddTicks(5829), "superadmin" });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdentitiesId",
                value: null);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "ClaimIdentity",
                columns: new[] { "Id", "ClaimsId", "IdentitiesId" },
                values: new object[] { 1, 10, null });
        }
    }
}
