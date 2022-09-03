using Microsoft.EntityFrameworkCore.Migrations;

namespace dgPadCms.Migrations
{
    public partial class manytomanytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTerm_Posts_PostId",
                table: "PostTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTerm_Terms_TermId",
                table: "PostTerm");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxonomyPostType_PostTypes_PostTypeId",
                table: "TaxonomyPostType");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxonomyPostType_Taxonomies_TaxonomyId",
                table: "TaxonomyPostType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxonomyPostType",
                table: "TaxonomyPostType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTerm",
                table: "PostTerm");

            migrationBuilder.RenameTable(
                name: "TaxonomyPostType",
                newName: "taxonomyPostTypes");

            migrationBuilder.RenameTable(
                name: "PostTerm",
                newName: "postTerms");

            migrationBuilder.RenameIndex(
                name: "IX_TaxonomyPostType_PostTypeId",
                table: "taxonomyPostTypes",
                newName: "IX_taxonomyPostTypes_PostTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PostTerm_TermId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "TaxonomyPostType");

            migrationBuilder.RenameTable(
                name: "postTerms",
                newName: "PostTerm");

            migrationBuilder.RenameIndex(
                name: "IX_taxonomyPostTypes_PostTypeId",
                table: "TaxonomyPostType",
                newName: "IX_TaxonomyPostType_PostTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_postTerms_TermId",
                table: "PostTerm",
                newName: "IX_PostTerm_TermId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxonomyPostType",
                table: "TaxonomyPostType",
                columns: new[] { "TaxonomyId", "PostTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTerm",
                table: "PostTerm",
                columns: new[] { "PostId", "TermId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostTerm_Posts_PostId",
                table: "PostTerm",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTerm_Terms_TermId",
                table: "PostTerm",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxonomyPostType_PostTypes_PostTypeId",
                table: "TaxonomyPostType",
                column: "PostTypeId",
                principalTable: "PostTypes",
                principalColumn: "PostTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxonomyPostType_Taxonomies_TaxonomyId",
                table: "TaxonomyPostType",
                column: "TaxonomyId",
                principalTable: "Taxonomies",
                principalColumn: "TaxonomyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
