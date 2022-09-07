using Microsoft.EntityFrameworkCore.Migrations;

namespace dgPadCms.Migrations
{
    public partial class Capitalletter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postTerms_Posts_PostId",
                table: "postTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_postTerms_Terms_TermId",
                table: "postTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_taxonomyPostTypes_PostTypes_PostTypeId",
                table: "taxonomyPostTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_taxonomyPostTypes_Taxonomies_TaxonomyId",
                table: "taxonomyPostTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_taxonomyPostTypes",
                table: "taxonomyPostTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_postTerms",
                table: "postTerms");

            migrationBuilder.RenameTable(
                name: "taxonomyPostTypes",
                newName: "TaxonomyPostTypes");

            migrationBuilder.RenameTable(
                name: "postTerms",
                newName: "PostTerms");

            migrationBuilder.RenameIndex(
                name: "IX_taxonomyPostTypes_PostTypeId",
                table: "TaxonomyPostTypes",
                newName: "IX_TaxonomyPostTypes_PostTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_postTerms_TermId",
                table: "PostTerms",
                newName: "IX_PostTerms_TermId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxonomyPostTypes",
                table: "TaxonomyPostTypes",
                columns: new[] { "TaxonomyId", "PostTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTerms",
                table: "PostTerms",
                columns: new[] { "PostId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostTerms_Posts_PostId",
                table: "PostTerms",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTerms_Terms_TermId",
                table: "PostTerms",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxonomyPostTypes_PostTypes_PostTypeId",
                table: "TaxonomyPostTypes",
                column: "PostTypeId",
                principalTable: "PostTypes",
                principalColumn: "PostTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxonomyPostTypes_Taxonomies_TaxonomyId",
                table: "TaxonomyPostTypes",
                column: "TaxonomyId",
                principalTable: "Taxonomies",
                principalColumn: "TaxonomyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTerms_Posts_PostId",
                table: "PostTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTerms_Terms_TermId",
                table: "PostTerms");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxonomyPostTypes_PostTypes_PostTypeId",
                table: "TaxonomyPostTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxonomyPostTypes_Taxonomies_TaxonomyId",
                table: "TaxonomyPostTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxonomyPostTypes",
                table: "TaxonomyPostTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTerms",
                table: "PostTerms");

            migrationBuilder.RenameTable(
                name: "TaxonomyPostTypes",
                newName: "taxonomyPostTypes");

            migrationBuilder.RenameTable(
                name: "PostTerms",
                newName: "postTerms");

            migrationBuilder.RenameIndex(
                name: "IX_TaxonomyPostTypes_PostTypeId",
                table: "taxonomyPostTypes",
                newName: "IX_taxonomyPostTypes_PostTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PostTerms_TermId",
                table: "postTerms",
                newName: "IX_postTerms_TermId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_taxonomyPostTypes",
                table: "taxonomyPostTypes",
                columns: new[] { "TaxonomyId", "PostTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_postTerms",
                table: "postTerms",
                columns: new[] { "PostId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_postTerms_Posts_PostId",
                table: "postTerms",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postTerms_Terms_TermId",
                table: "postTerms",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taxonomyPostTypes_PostTypes_PostTypeId",
                table: "taxonomyPostTypes",
                column: "PostTypeId",
                principalTable: "PostTypes",
                principalColumn: "PostTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_taxonomyPostTypes_Taxonomies_TaxonomyId",
                table: "taxonomyPostTypes",
                column: "TaxonomyId",
                principalTable: "Taxonomies",
                principalColumn: "TaxonomyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
