using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTypes",
                columns: table => new
                {
                    PostTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypes", x => x.PostTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomies",
                columns: table => new
                {
                    TaxonomyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomies", x => x.TaxonomyId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(nullable: false),
                    PostTypeId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "PostTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxonomyPostTypes",
                columns: table => new
                {
                    TaxonomyId = table.Column<int>(nullable: false),
                    PostTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxonomyPostTypes", x => new { x.TaxonomyId, x.PostTypeId });
                    table.ForeignKey(
                        name: "FK_TaxonomyPostTypes_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "PostTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxonomyPostTypes_Taxonomies_TaxonomyId",
                        column: x => x.TaxonomyId,
                        principalTable: "Taxonomies",
                        principalColumn: "TaxonomyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    TaxonomyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermId);
                    table.ForeignKey(
                        name: "FK_Terms_Taxonomies_TaxonomyId",
                        column: x => x.TaxonomyId,
                        principalTable: "Taxonomies",
                        principalColumn: "TaxonomyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTerms",
                columns: table => new
                {
                    TermId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTerms", x => new { x.PostId, x.TermId });
                    table.ForeignKey(
                        name: "FK_PostTerms_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTerms_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Admin", "Admin" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "Editor", "Editor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "546533c2-6689-4e72-94a6-bcffa2d11415", "admin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEImnslrNtq6J0d/W0wqcUezv+CBO2aVmJxEs3A0U2W2CDmmk8tF4gdlcPoPe2JtPPQ==", "1234567890", false, "86f358fe-494c-4e1d-8ef7-356f366cda93", false, "Admin" },
                    { "b74ddd14-6340-4840-95c2-db12554843e4", 0, "2c384fda-bd87-4444-affe-ec3c002228a0", "Editor@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGarCoD2QGJXUib21RKvvRR06+2jHSqIoa15+cdSpuNm/uRN41EnGCY96DJBzv1x1Q==", "1234567890", false, "fa058bd5-57c2-40eb-9fc4-cd89906c76f8", false, "Editor" }
                });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "PostTypeId", "Code", "Title" },
                values: new object[,]
                {
                    { 1, "Article", "Article" },
                    { 2, "Page", "Page" },
                    { 3, "Event", "Event" }
                });

            migrationBuilder.InsertData(
                table: "Taxonomies",
                columns: new[] { "TaxonomyId", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "Gaming", "Gaming" },
                    { 2, "Sport", "Sport" },
                    { 3, "News", "News" },
                    { 4, "Location", "Location" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b74ddd14-6340-4840-95c2-db12554843e5", "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { "b74ddd14-6340-4840-95c2-db12554843e4", "c7b013f0-5201-4317-abd8-c211f91b7330" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreationDate", "Details", "Image", "PostTitle", "PostTypeId", "Summary" },
                values: new object[,]
                {
                    { 14, "10/10/2022 10:00 AM", @"Today, the FDA published the FDA Voices: “FDA Continues Important Work on Substance Use and Overdose Prevention Efforts,” by Robert M. Califf, M.D., Commissioner of Food and Drugs. The National Academies for Science, Engineering, and Medicine (NASEM) report ""Pain Management and the Opioid Epidemic,"" contained recommendations for the FDA’s consideration, as well as broader recommendations for federal agencies, state and local governments, and health-related organizations. As we continue to prioritize our substance use and overdose prevention efforts, the NASEM report has been and will remain an important source to consider in our decision making.
                Today, the FDA published a Constituent Update to remind owners, operators, or agents in charge of a domestic or foreign food facility engaged in manufacturing/processing, packing, or holding food for consumption by humans or animals in the U.S, to register the facility with FDA or to renew their FDA registration between October 1 and December 31, 2022. 
                On Thursday, the FDA approved SpectoGard, the first generic spectinomycin sulfate injectable solution for the treatment of bovine respiratory disease (pneumonia). SpectoGard contains the same active ingredient (spectinomycin sulfate) in the same concentration and dosage form as the approved brand name drug product, Adspec, which was first approved in January 1998. SpectoGard is only available by prescription because a veterinarian’s expertise is required to determine if SpectoGard is an appropriate treatment for cattle. SpectoGard is sponsored by Bimeda Animal Health Ltd.
                On Wednesday, the FDA issued a warning letter jointly with the Federal Trade Commission to Bespoke Apothecary LLC for selling unapproved and misbranded COVID kit and Post Virus Recovery Herbal Tea products as drugs for use in treating or preventing COVID-19. Consumers concerned about COVID-19 should consult with their health care provider.
                On Wednesday, the FDA approved Simplera Otic Solution, the first generic animal drug product that has single dose treatment with a 30-day duration of effect for otitis externa (outer ear infection) in dogs. Simplera Otic Solution is a prescription product that contains the same active ingredients in the same concentration and dosage form as the approved brand name drug product, Claro, which FDA first approved in September 2015. Simplera is sponsored by Vetoquinol USA, Inc.
                On Tuesday, the FDA announced updates to its COVID-19 test policy to address public health testing needs during this phase of the COVID-19 public health emergency. Over the last two years more than 400 COVID-19 tests have been granted emergency use authorization and there are generally enough at-home tests, tests that can be used at the point-of-care such as health clinics, and laboratory-based tests to meet testing needs. The FDA is revising its COVID-19 test policy to encourage most COVID-19 test developers to pursue a traditional premarket review pathway for their tests, rather than emergency use authorization. The FDA intends to prioritize its review of emergency use authorization requests on COVID-19 diagnostic tests that are likely to have a significant public health benefit or are likely to fulfill an unmet need. This could include novel technologies like the use of breath samples, or unique features like the ability of a test to detect a new SARS-CoV-2 virus variant. The FDA actions include: 
                Reissuing the Policy for Coronavirus Disease-2019 Tests During the Public Health Emergency (Revised).
                Updating the FAQs on Testing for SARS-CoV-2.
                COVID-19 testing updates:
                As of today, 437 tests and sample collection devices are authorized by the FDA under emergency use authorizations (EUAs). These include 300 molecular tests and sample collection devices, 85 antibody and other immune response tests, 51 antigen tests, and 1 diagnostic breath test. There are 79 molecular authorizations and 1 antibody authorization that can be used with home-collected samples. There is 1 EUA for a molecular prescription at-home test, 2 EUAs for antigen prescription at-home tests, 19 EUAs for antigen over-the-counter (OTC) at-home tests, and 3 for molecular OTC at-home tests.
                The FDA has authorized 31 antigen tests and 8 molecular tests for serial screening programs. The FDA has also authorized 1124 revisions to EUA authorizations. ", "20221001_075548_CBell_110_1664633642670_photo_optimized.jpg", "FDA Roundup: September 30, 2022 ", 3, "Today, the U.S. Food and Drug Administration is providing an at-a-glance summary of news from around the agency:" },
                    { 13, "10/10/2022 10:00 AM", @"The five sessions of the October 2022 conference (October 1–2) is being broadcast live from Temple Square in Salt Lake City in 70 languages. This page provides a summary of the conference’s sermons, news and announcements.

                General Conference News

                Was the Prophet Seated While He Spoke? President Nelson Explains
                Church Publishes New Youth Guide
                Eight General Authority Seventies Released; Six Area Seventies Called
                Session Summaries

                Saturday Morning
                Saturday Afternoon
                Saturday Evening
                Sunday Morning
                Sunday Afternoon
                Resources

                How to Watch General Conference
                The October 2022 World Report
                Invitations President Nelson Has Given Since He Became Prophet
                General Conference Activities for Children and Youth
                What Does It Take to Produce General Conference?", "20221001_095504_CBell_CMB_4463.jpg", "October 2022 General Conference News and Announcements", 3, "General conferences of The Church of Jesus Christ of Latter-day Saints take place every six months." },
                    { 12, "10/10/2022 10:00 AM", @"This video breaks down the franchise chronologically, charting the story of Kratos from a hot headed youth, through to a captain in the Spartan army all before his grand odyssey through the Greek and Norse mythologies.

                With God of War Ragnarök set to further slide the franchise’s anti-hero, Kratos, into a mythological mire, what better time to dive back into the Ghost of Sparta’s saga of gods and monsters.", "gow.jpg", "The Complete God of War Timeline Explained!", 3, "The God of War franchise has a sprawling timeline that interweaves its Great Greek Tragedy across 9 games, and 2 wildly distinct mythologies. But how does it all tie together?" },
                    { 11, "10/10/2022 10:00 AM", @"I love Left 4 Dead, and I tend to enjoy many of the games it's clearly inspired over the years --and there are a lot. Sensing there's no end in sight to games inspired by Valve's seminal co-op horde shooter, even as Left 4 Dead 3 doesn't appear to be likely itself, I wanted to find out what makes Left 4 Dead such a milestone. More importantly, I wanted to hear it from the teams that have taken the baton from Valve and carried it in different directions, adding their own touches to the time-tested formula but always nodding back to that landmark original game.

                ""It keeps the right things simple,"" Chet Faliszek told me earlier this month about Left 4 Dead. Faliszek worked on both Left 4 Dead games at Valve, and spends these days at his new studio, Stray Bombay, building a new L4D-inspired game: The Anacrusis. The co-op shooter places a lot of the foundational L4D gameplay in a sci-fi setting akin to the original Star Trek. ""I still see games that greet you with confusing interfaces or a forced tutorial that gets in the way of inviting a friend who is new into your game. Left 4 Dead gets out of the way and lets you jump into the game and have some fun.""

                Faliszek was addressing a question I posed to his and four other teams, each of them having worked on games that can reasonably be called Left 4 Dead descendents. Around the world, games like Systemic Reaction's Second Extinction, Saber Interactive's World War Z, Fatshark's Warhammer: Vermintide and Darktide, and Ghost Ship Games' Deep Rock Galactic have roots that trail back to Left 4 Dead, some more than others, but all of them are undeniably inspired by it. His response was not uncommon among the group of devs I spoke to. In my interviews with the five studios, each team repeatedly cited two assets that Left 4 Dead maintains to this day: simplicity and replayability.

                ""Initially [World War Z] was supposed to be a completely different game that didn’t have any resemblance to L4D,"" Saber Lead Game Designer Dmitry Grigorenko told me. ""Funny thing is, when you make a co-op shooter game about zombies, there aren’t many ways that you can go. Somewhere in the middle of the development after another playtest we sat down together as a team and said, 'Okay, our game is beginning to look a lot like L4D.''' Grigorenko said the team began to study how Left 4 Dead's famous AI Director behaved so that Saber could implement something similar.

                This was a problem that grew in scope for the team, as it had to authentically capture the look of its source material, including the mountainous swarms of undead that far outnumber the horde sizes in Left 4 Dead. ""Adding more zombies sounds simple on paper, but our zombie swarm system is incredibly complex. Zombies need to behave like a real crowd; you cannot achieve that just by increasing numbers. AI, animation and level design needs to work very well together to make sure that these sequences look like scenes in the movie.""", "left4dead.jpg", "What Made Left 4 Dead Special, According To The Devs Making Games Like It", 3, "Left 4 Dead is a trailblazing game still remembered fondly today. GameSpot spoke with several teams making games like it to try and figure out what makes it timeless." },
                    { 9, "10/10/2022 10:00 AM", @"Up for debate: Would Man City fill a Manchester XI in post-Ferguson era?
                ""There will be zero problem, I am 100% convinced. They know what is the strategy, what they have to do for right now, the day after tomorrow, after the World Cup, next season and the next season.

                ""When the club depends on one person we have problems, as the club is not solid, isn't stable.

                ""The foundations of the club come from many and if the club just depends on 'Pep' it is because we have not done really well in this period.""

                During his time in charge, Guardiola has won nine major trophies with Manchester City, including four Premier League titles.

                They became the first English men's team to win the domestic treble - Premier League, Carabao Cup and FA Cup - in 2019.

                This season they are chasing a fifth league title in six campaigns, having retained the trophy for a second successive year in 2021-22.

                ""I never buy a player, I never sell a player, it's not my money,"" added Guardiola. ""It is the club - 'club' is the most important word and every decision we make is thinking about the club. Today, the day after and for the future.

                ""The club knows the drill really well, the type of players that we want to play with me and without me.""", "_126924050_gettyimages-1243598126.jpg", "Pep Guardiola: 'Manchester City have future strategy without me'", 2, @"Manchester City manager Pep Guardiola believes the club will be able to progress after his departure because it has a ""strategy"" in place.

                The 51-year-old is in the final year of his contract, though he has given no indication he intends to leave.

                Since joining City from Bayern Munich in 2016 on an initial three-year deal, Guardiola has signed two contract extensions.

                ""The club knows exactly what is the target, the next step,"" he said when asked about City's future should he leave." },
                    { 8, "10/10/2022 10:00 AM", @"The administration’s approach relies heavily on throwing money at perceived shortfalls in US industrial and technological capacity rather than removing structural impediments on the US innovation ecosystem. The bipartisan embrace of industrial policy, symbolised best in the over two-thirds Senate support for the ‘anti-China bill,’ the Innovation and Competition Act, has yet to show that it can transcend the pitfalls of partisan politics and domestic economic rent-seeking.

                Biden’s economic agenda is also inwardly, rather than outwardly, focused with domestic economic objectives prioritised over international economic engagement. In particular, new trade agreements are for the most part seen as a non-starter, lacking congressional support or presidential leadership. US allies, keen to see Biden return to the international economic rule-making space vacated by the Trump administration, will have to settle for more ad hoc and less ambitious forms of economic cooperation.

                WHILE THE BIG SPENDING BILLS PROPOSED ARE INDICATIVE OF THE ADMINISTRATION’S DETERMINATION TO EXTEND A STRONG DOMESTIC ECONOMIC RECOVERY FROM THE PANDEMIC, THE FACT THAT MUCH OF THE LEGISLATION HAS YET TO PASS HIGHLIGHTS MANY OF THE DOMESTIC POLITICAL AND ECONOMIC CONSTRAINTS ON THE ADMINISTRATION’S AGENDA.
                Issues of supply chain security loom large for the United States and its allies. The global outbreak of inflationary pressures on the back of supply chain bottlenecks has underscored the issues of supply chain resilience brought to the fore by the COVID-19 pandemic. The secular decline in the prices of durable goods has undergone a dramatic reversal, with US inflation at its highest rate since 1982.25

                Inflationary pressures and the shortfalls in supply are mostly due to dramatic shifts in demand brought about by changed consumptions patterns induced by the pandemic. The slow supply response to these demand shifts was also exacerbated by under-investment in new production capacity and related infrastructure brought about by the 2020 pandemic downturn.

                On balance, global supply chains did well to pivot in response to these demand shifts by increasing output as quickly as they did. No supply chain configuration, regardless of how domiciled, could have easily accommodated such massive demand shifts. Rising prices are already inducing supply responses that will ultimately see a return to pre-pandemic disinflationary pressures.

                One example of this is the US supply of semiconductors is not only ensnared in this pandemic-induced shift in demand but also a key battleground in the strategic rivalry between the United States and China, as Jennifer Jackett’s contribution makes clear. As with the US response to trade competition with Japan in the 1980s, recently proposed subsidies for domestic chip manufacturing aim not only to address temporary supply shortfalls but to maintain technological dominance over China’s emerging chip sector and provide supply chain security for the critical tech sector.

                The Biden administration’s so-called ‘foreign policy for the middle class,’ referred to extensively by key members of his administration, suggests the same domestic orientation as Trump’s ‘America First.’ Accordingly, integrating its domestic economic agenda with industrial and technological cooperation with allies will remain one of the administration’s biggest challenges going forward.

                It is also a form of policy integration that the US Government is poorly equipped to deliver. US state capacity remains highly fragmented between domestic and international policymaking silos. Even where the international-facing arms of the US Government may want to progress alliance cooperation, the domestic-facing arms will pull attention back to domestic policy issues and priorities.

                ", "america-competes-act.jpg", "THREATS TO AND OPPORTUNITIES FOR US ECONOMIC AND TECHNOLOGICAL POWER", 2, @"Overview
                by Dr Stephen Kirchner

                The Biden administration came to office with an ambitious domestic economic agenda, exemplified by the largest ever peacetime federal spending and budget deficits in its first year. While the big spending bills the administration proposed — like the American Jobs Plan and the American Families Plan — are indicative of the administration’s determination to extend a strong domestic economic recovery from the pandemic, the fact that much of the legislation has yet to pass highlights many of the domestic political and economic constraints on the administration’s agenda.

                Major spending bills have been held up as the administration tries to manage competing demands from the Democratic Party’s progressive wing and its conservatives like West Virginia Senator Joe Manchin. The magnitude of the proposed spending is a challenge from the standpoint of state capacity, with long timelines separating legislation from the delivery of new programs on the ground. As USSC Non-Resident Fellow Jennifer Jackett’s review of the measures proposed under the Innovation and Competition Act and the America Competes Act suggests, the US political system continually puts the brakes on further practical action." },
                    { 10, "10/10/2022 10:00 AM", @"""The shirt has become stained with political meaning since 2014,"" says Mateus Gamba Torres, a history professor at the University of Brasília.

                Eight years ago, millions of Brazilians took to the streets to protest against the then-President, Dilma Rousseff, dressed in the colours of the flag as they demanded the left-winger's impeachment.

                Then in 2018, the colours were again used by the current president - far-right Jair Bolsonaro.

                This year too, green, yellow and blue are the key colours at Mr Bolsonaro's rallies, with people wearing T-shirts, the national flag and accessories.

                ""The green and yellow shirt has become a symbol of those related to Bolsonaro's government,"" Mr Gamba Torres says, ""which means a good part of the population no longer identify with it.""

                Former Brazilian president Lula at a campaign rally in Manaus.
                Former Brazilian president Lula standing in front of the Brazilian flag on-screen at a campaign rally in Manaus
                João's encounter with the shop owner is not the only reason he is now hesitant to talk politics. In Brazil, political disputes can seemingly get deadly.

                In July, Marcelo Aloizio de Arruda - a supporter of former president and left-wing candidate Luiz Inácio Lula da Silva - was shot dead at his 50th birthday party, allegedly by a police officer shouting in support of right-wing President Bolsonaro.

                Before he died, Mr Arruda retaliated and shot his alleged attacker - who spent some time in hospital before being sent to prison, where he awaits trial.

                And on 9 September, 44-year-old Benedito Cardoso dos Santos was allegedly killed by a colleague, following a heated political discussion between the two. The 22-year-old suspect remains in police custody.

                Tech programmer Ruy Araújo Souza Júnior, 43, tells BBC News he will only wear the shirt at home, to avoid being mistaken for a Bolsonaro supporter.

                If ex-President Lula wins the election, he hopes the shirt will ""once again unite us and symbolise true love of our country, not a political party"".

                Left-wing candidate Lula has focused on ""reclaiming"" the flag. Several of his supporters, such as singer Ludmilla, international star Anitta, and rapper Djonga, have made a point of wearing the shirt during their performances.

                Djonga, who was part of Nike's official campaign for the Brazilian World Cup kit, told a crowd at one concert that wearing the shirt in public was an act of protest.

                ""They [Bolsonaro supporters] think everything is theirs, they appropriate the meaning of family, they appropriate our national anthem, they appropriate everything,"" he said. ""But here's the truth: everything is ours, nothing is theirs.""

                But it's not just Mr Bolsonaro's opponents who are wary of wearing the shirt.

                ""I'm a patriot and right-wing. I really want to vote wearing my yellow shirt,"" says Bolsonaro supporter Alessandra Passos, 41.

                But due to the tense environment between voters, she says, she is ""afraid to wear it on voting day"".", "_126896636_richarlison_getty.jpg", "Brazil election: How the famous yellow football shirt has become politicised", 2, @"When the much-awaited Brazil 2022 World Cup shirt was released in August, student João Vitor Gonçalves de Oliveira rushed to get his hands on the kit.

                The 20-year-old went to the nearest store, grabbed the famous yellow and green top and took it to the till, where he was met with an excited smile.

                ""The shop owner assumed I support the current government because I was buying the shirt, and started to rage against left-wing candidate Lula,"" João tells the BBC.

                João does not support the government of Jair Bolsonaro, who is standing for re-election on Sunday. But buying the shirt, he realised in the store, could make people think he did.

                In order to avoid confrontation, João pretended to be a Bolsonaro supporter. It was another sign that the yellow and green shirt - made famous by Pele, Ronaldo, and many others - has become a symbol of a divided nation." },
                    { 6, "10/10/2022 10:00 AM", @"We’ll see you in court
                Want to found out the latest on a big trial? Fox News has all of the updates on court proceedings, jury verdicts, and all of the drama surrounding some of the most high-profile court cases in the country. Watch events unfold in real time with our live blog and in-court coverage of the most talked about criminal investigations in America.

                Breaking crime news
                Fox News' staff of journalists are dedicated to getting you the most compelling crime coverage in America with the most accurate and constantly updated information you will find in digital media. With our phone app, you can even get instant notifications on breaking crime news, and watch breaking news as it happens, wherever you are.", "Crime-scene.jpg", "CRIME", 1, "Fox News offers up-to-the-second crime coverage using our unmatched resources to keep you informed on everything from news about notorious criminals, brave law enforcement officers and their beats, the latest homicides and robberies, and the most intriguing court cases. Be the first to know as law enforcement conduct manhunts, investigate shootings, and make high-profile arrests." },
                    { 5, "10/10/2022 10:00 AM", @"Diplomacy
                Russia failed to win enough votes for re-election to the United Nations aviation agency’s governing council, in a boost for Western powers that want to hold Moscow accountable following its invasion of Ukraine.
                Germany will deliver the first of four advanced IRIS-T air defence systems to Ukraine in the coming days to help ward off drone attacks, defence minister Christine Lambrecht said during an unannounced visit to Odesa.
                Zaporizhzhia nuclear plant
                A Russian patrol detained the director general of Ukraine’s Russian-occupied Zaporizhzhia nuclear power plant, the state-owned company in charge of the plant said. The UN nuclear watchdog said Russia had confirmed the move.
                International Atomic Energy Agency chief Rafael Grossi is expected to hold talks in Moscow and Kyiv in the coming days on the creation of a protection zone around the Russian-held plant, the UN watchdog said.
                Gas flows
                Italy’s Eni said it would not receive any of the gas it had requested from Russia’s Gazprom for delivery on Saturday, but the firms said they were working to fix this.
                Greece and Bulgaria started the commercial operation of a long-delayed gas pipeline that will help decrease southeast Europe’s dependence on Russian gas and boost energy security.
                The Danish Energy Agency says one of two ruptured natural gas pipelines in the Baltic Sea appears to have stopped leaking gas.", "2022-10-01T221800Z_1690564228_RC2HSW9FAIYV_RTRMADP_3_UKRAINE-CRISIS-LYMAN-CONTROL-UGC.jpg", "Russia-Ukraine war: List of key events, day 221", 1, "As the Russia-Ukraine war enters its 221st day, we take a look at the main developments." },
                    { 4, "10/10/2022 10:00 AM", @"At least 174 people have been killed in a riot at a football match in Indonesia, most of whom were trampled to death after police fired tear gas, in one of the world's worst sporting disasters.

                Angry at their team's first home defeat by the rival club in 23 years, thousands of Arema supporters invaded the pitch and threw bottles and other missiles at players and football officials.

                Clashes spread outside the stadium where at least five police vehicles were overturned and set on fire.

                Riot police responded by firing tear gas, including towards the stadium's stands, sparking panic among the crowd.

                Tear gas is banned at football stadiums by the international governing body FIFA.

                ""The football world is in a state of shock following the tragic incidents that have taken place in Indonesia at the end of the match between Arema FC and Persebaya Surabaya at the Kanjuruhan Stadium,"" FIFA president Gianni Infantino said.

                ""This is a dark day for all involved in football and a tragedy beyond comprehension. I extend my deepest condolences to the families and friends of the victims who lost their lives following this tragic incident.

                ""Together with FIFA and the global football community, all our thoughts and prayers are with the victims, those who have been injured, together with the people of the Republic of Indonesia, the Asian Football Confederation, the Indonesian Football Association, and the Indonesian Football League, at this difficult time.""

                Some people were suffocated and others trampled as hundreds ran to the exit in a bid to escape the chemical.", "skysports-kanjuruhan-stadium_5916985.jpg", "Indonesia: At least 174 people killed after riot at football match", 1, "Thousands of Arema supporters invaded the pitch and threw bottles and other missiles at players and football officials after their side's first home defeat by a rival club in 23 years, leading to clashes and the use of a crowd control chemical banned at stadiums by FIFA" },
                    { 3, "10/10/2022 10:00 AM", @"After a series that has swayed one way and then the other, the two teams are locked at 3-3 after six of the seven games - although England should arguably have sewn up the silverware already.

                Bungled run chases in the fourth and fifth matches in pursuit of modest totals cost them and left them needing to win Friday's penultimate fixture, also in Lahore, to keep the series alive.", "engvspak.jpg", "England face Pakistan in T20 series decider as they get knockout vibes ahead of World Cup", 1, "even-match T20I series between Pakistan and England to be settled in Lahore on Sunday; watch on Sky Sports Cricket from 3pm ahead of the first ball at 3.30pm; Phil Salt blazed 88 from 41 balls last time out as England won sixth match by eight wickets" },
                    { 2, "10/10/2022 10:00 AM", @"Matchmaking update and recalibration
                On August 2nd, 2022, Valve released a big update to the CS:GO’s matchmaking system that affected all the players globally.

                When you launch CS:GO, you’ll notice that your Skill Group is not displayed–you’ll have to win one more match to reveal your Skill Group. Most of you will notice a change to your Skill Group, but some of you may find that you were already in the right place.

                — Valve

                Previously, smaller regions had a bottom-heavy distribution, while Europe (the most populated one) had a top-heavy one. Now it should feel harder to rank up in Europe because the players in the top half of the curve have been redistributed. Instead, in North America matchmaking quality should be improved as before there was a high skill gap among players at mid-ranks.

                There is certainly room for improvements, but Valve did a good job with the new rank distribution and matchmaking algorithm.", "CSGO+rank+distribution+Europe+August+2022.jpg", "CS:GO RANK DISTRIBUTION AND PERCENTAGE OF PLAYERS", 1, " realistic rank distribution in CS:GO - updated monthly. Find out the percentage of players by rank and the true value of your skill." },
                    { 1, "10/10/2022 10:00 AM", @"<p>CS:GO is one of the games with the largest number of esports events. From its release, over 69 million dollars have been awarded in 3858 tournaments, and the previous iterations of the game (Counter-Strike 1.6 and Counter-Strike: Source) handed out 15 million dollars in 1200 tournaments from 2000 to 2013.

                Every year, the best pro players in the world take part at the CS:GO Major Championships: Valve-sponsored events with a prize pool of $1,000,000 USD. There are also Minor Championships with a monetary prize of $50,000 that act as qualifiers for the Major. The minors are separated in 4 regions: Americas, Asia, CIS, and Europe.

                The prize pool of the Majors can’t be compared to The International (Valve-sponsored Dota 2 event), but the most popular CS:GO players and teams are able to earn a huge additional income via the tournament stickers sold in-game during each Major.</p><p>#	Nickname	Name	Country	Earnings
                1	dupreeh	Peter Rasmussen	Denmark	$1,772,722
                2	Xyp9x	Andreas Højsleth	Denmark	$1,771,621
                3	dev1ce	Nicolai Reedtz	Denmark	$1,737,223
                4	gla1ve	Lukas Rossander	Denmark	$1,602,084
                5	Magisk	Emil Reif	Demark	$1,366,181
                6	Stewie2k	Jakey Yip	United States	$1,076,740
                7	TACO	Epitácio de Melo	Brazil	$1,062,989
                8	FalleN	Gabriel Toledo	Brazil	$1,059,070
                9	fer	Fernando Alvarenga	Brazil	$1,053,170
                10	coldzera	Marcelo David	Brazil	$1,002,401
                11	NAF	Keith Markovic	Canada	$972,165
                12	karrigan	Finn Andersen	Denmark	$945,035
                13	nitr0	Nick Cannella	United States	$920,151
                14	ELiGE	Jonathan Jablonowski	United States	$920,096
                15	olofmeister	Olof Kajbjer	Sweden	$876,761
                16	JW	Jesper Wecksell	Sweden	$869,960
                17	flusha	Robin Rönnquist	Sweden	$849,868
                18	KRiMZ	Freddy Johansson	Sweden	$840,023
                19	Twistzz	Russel Van Dulken	Canada	$824,776
                20	GuardiaN	Ladislav Kovács	Slovakia	$798,520</p>", "Astralis+won+FACEIT+London+Major+2018.jpg", "THE TOP 20 HIGHEST-PAID CS:GO ESPORTS PLAYERS IN THE WORLD", 1, "This list indicates the top 20 highest-paid Counter-Strike: Global Offensive players in the world. It considers only earnings from professional esports tournaments." },
                    { 7, "10/10/2022 10:00 AM", @"
                Predicting that as much as Australia might have feared becoming a target of the Biden administration’s climate agenda, US political realities would “limit broader congressional legislation on climate change” and that such differences would “not in any way threaten the deep fundamental relationship between the two countries” because the administration’s efforts would mostly be limited to executive orders and rhetoric. This insight has proven correct.
                Cautioning that trade would “not be an urgent priority for the administration relative to domestic issues” since actualised by the Biden administration leaving intact much of the Trump administration’s protectionist and inward-focused trade policies.
                Urging Australia to pursue “innovative ways to advance defence industry integration with the United States, including by coordinating with Canada and the United Kingdom” — the sort of integration now sought through the AUKUS agreement.
                Warning that ever-deepening political polarisation would constrain much of the Biden administration’s ambitious agenda to a few key areas: an infrastructure package as well as domestic and defence investments, which help the United States compete with and better address the China challenge.1
                When asked at the launch event for State of the United States in March 2021 how the US Government envisioned a pathway for an ambitious Biden administration agenda amid such overwhelming political unrest, the State Department’s Deputy Assistant Secretary of State Atul Keshap posited that, “America is a society that is constantly innovating and reinventing itself. We’re kind of like that wobble doll, where you punch it and then it sort of wobbles back at you. There’s a lot of resiliency.”2

                Keshap’s optimism mirrors that of Joe Biden himself, who famously said while campaigning for president in 2019 that Republicans would have an “epiphany” and turn away from Donald Trump once he was out of office.3

                Alas, our analysis leads us to a different conclusion, and one with some bracing implications for Australian policymakers and strategic thinkers.

                ", "scott-morrison-joe-biden-team.jpg", "STATE OF THE UNITED STATES: BIDEN’S AGENDA IN THE BALANCE", 2, @"Where the United States was a year ago

                In January 2021 alone, a deadly insurrection overtook the US Capitol for the first time in US history, a record 96,654 Americans died from COVID-19, and Joseph R. Biden Jr became the 46th president of the United States.

                A few weeks later the United States Studies Centre (USSC) published its inaugural State of the United States, with the theme “An evolving alliance agenda.” Key elements of that report were:" }
                });

            migrationBuilder.InsertData(
                table: "TaxonomyPostTypes",
                columns: new[] { "TaxonomyId", "PostTypeId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 4, 3 },
                    { 4, 2 },
                    { 4, 1 },
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 1 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "TermId", "Code", "Name", "TaxonomyId" },
                values: new object[,]
                {
                    { 21, "GOW", "God of War", 1 },
                    { 15, "Indonesia", "Indonesia", 4 },
                    { 14, "Pakistan", "Pakistan", 4 },
                    { 13, "England", "England", 4 },
                    { 12, "USA", "USA", 4 },
                    { 11, "Russia", "Russia", 4 },
                    { 10, "Lebanon", "Lebanon", 4 },
                    { 1, "New Game", "New Game", 1 },
                    { 17, "Ukraine", "Ukraine", 4 },
                    { 9, "War", "War", 3 },
                    { 7, "Crimes", "Crimes", 3 },
                    { 2, "Tournament", "Tournament", 1 },
                    { 3, "CSGO", "CSGO", 1 },
                    { 18, "Manchester City", "Manchester City", 2 },
                    { 16, "Cricket", "Cricket", 2 },
                    { 6, "Football", "Football", 2 },
                    { 5, "Riot", "Riot", 2 },
                    { 4, "World Cup", "World Cup", 2 },
                    { 20, "Left 4 Dead", "Left 4 Dead", 1 },
                    { 8, "Politics", "Politics", 3 },
                    { 19, "Brazil", "Brazil", 4 }
                });

            migrationBuilder.InsertData(
                table: "PostTerms",
                columns: new[] { "PostId", "TermId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 7, 8 },
                    { 10, 8 },
                    { 13, 8 },
                    { 14, 8 },
                    { 5, 9 },
                    { 5, 11 },
                    { 6, 12 },
                    { 7, 12 },
                    { 8, 12 },
                    { 13, 12 },
                    { 14, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 4, 15 },
                    { 5, 17 },
                    { 6, 8 },
                    { 5, 8 },
                    { 8, 7 },
                    { 7, 7 },
                    { 11, 1 },
                    { 12, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 11, 20 },
                    { 12, 21 },
                    { 7, 17 },
                    { 3, 4 },
                    { 9, 6 },
                    { 10, 6 },
                    { 3, 16 },
                    { 9, 18 },
                    { 4, 7 },
                    { 5, 7 },
                    { 6, 7 },
                    { 4, 6 },
                    { 10, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeId",
                table: "Posts",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTerms_TermId",
                table: "PostTerms",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxonomyPostTypes_PostTypeId",
                table: "TaxonomyPostTypes",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_TaxonomyId",
                table: "Terms",
                column: "TaxonomyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PostTerms");

            migrationBuilder.DropTable(
                name: "TaxonomyPostTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "PostTypes");

            migrationBuilder.DropTable(
                name: "Taxonomies");
        }
    }
}
