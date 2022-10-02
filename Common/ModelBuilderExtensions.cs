using dgPadCms.Models;
using Microsoft.EntityFrameworkCore;


namespace Common
{
    public static class ModelBuilderExtensions
    {
        public static void Taxonomy(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxonomy>().HasData(
                new Taxonomy
                {
                    TaxonomyId = 1,
                    Code = "Gaming",
                    Name = "Gaming"
                },
                new Taxonomy
                {
                    TaxonomyId = 2,
                    Code = "Sport",
                    Name = "Sport"
                },
                new Taxonomy
                {
                    TaxonomyId = 3,
                    Code = "News",
                    Name = "News"
                },
                new Taxonomy
                {
                    TaxonomyId = 4,
                    Code = "Location",
                    Name = "Location"
                }
                );
        }

        public static void Term(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Term>()
                .HasOne(t => t.Taxonomy)
                .WithMany(te => te.Terms);

            modelBuilder.Entity<Term>().HasData(
                new Term
                {
                    TermId = 1,
                    Code = "New Game",
                    Name = "New Game",
                    TaxonomyId = 1,
                },
                new Term
                {
                    TermId = 2,
                    Code = "Tournament",
                    Name = "Tournament",
                    TaxonomyId = 1
                },
                new Term
                {
                    TermId = 3,
                    Code = "CSGO",
                    Name = "CSGO",
                    TaxonomyId = 1
                },
                new Term
                {
                    TermId = 20,
                    Code = "Left 4 Dead",
                    Name = "Left 4 Dead",
                    TaxonomyId = 1
                },
                new Term
                {
                    TermId = 21,
                    Code = "GOW",
                    Name = "God of War",
                    TaxonomyId = 1
                },
                new Term
                {
                    TermId = 4,
                    Code = "World Cup",
                    Name = "World Cup",
                    TaxonomyId = 2
                },
                new Term
                {
                    TermId = 5,
                    Code = "Riot",
                    Name = "Riot",
                    TaxonomyId = 2
                },
                new Term
                {
                    TermId = 6,
                    Code = "Football",
                    Name = "Football",
                    TaxonomyId = 2
                },
                new Term
                {
                    TermId = 16,
                    Code = "Cricket",
                    Name = "Cricket",
                    TaxonomyId = 2
                },
                new Term
                {
                    TermId = 18,
                    Code = "Manchester City",
                    Name = "Manchester City",
                    TaxonomyId = 2
                },
                new Term
                {
                    TermId = 7,
                    Code = "Crimes",
                    Name = "Crimes",
                    TaxonomyId = 3
                },
                new Term
                {
                    TermId = 8,
                    Code = "Politics",
                    Name = "Politics",
                    TaxonomyId = 3
                },
                new Term
                {
                    TermId = 9,
                    Code = "War",
                    Name = "War",
                    TaxonomyId = 3
                },
                new Term
                {
                    TermId = 10,
                    Code = "Lebanon",
                    Name = "Lebanon",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 11,
                    Code = "Russia",
                    Name = "Russia",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 12,
                    Code = "USA",
                    Name = "USA",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 13,
                    Code = "England",
                    Name = "England",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 14,
                    Code = "Pakistan",
                    Name = "Pakistan",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 15,
                    Code = "Indonesia",
                    Name = "Indonesia",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 17,
                    Code = "Ukraine",
                    Name = "Ukraine",
                    TaxonomyId = 4
                },
                new Term
                {
                    TermId = 19,
                    Code = "Brazil",
                    Name = "Brazil",
                    TaxonomyId = 4
                }
                );

        }

        public static void PostType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostType>().HasData(
                new PostType
                {
                    PostTypeId = 1,
                    Title = "Article",
                    Code = "Article"
                },
                new PostType
                {
                    PostTypeId = 2,
                    Title = "Page",
                    Code = "Page"
                },
                new PostType
                {
                    PostTypeId = 3,
                    Title = "Event",
                    Code = "Event"
                }
                );
        }

        public static void TaxonomyPostType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaxonomyPostType>()
               .HasKey(tp => new { tp.TaxonomyId, tp.PostTypeId });

            modelBuilder.Entity<TaxonomyPostType>()
                .HasOne(tp => tp.Taxonomy)
                .WithMany(t => t.TaxonomyPostTypes)
                .HasForeignKey(tp => tp.TaxonomyId);

            modelBuilder.Entity<TaxonomyPostType>()
                .HasOne(tp => tp.PostType)
                .WithMany(p => p.TaxonomyPostTypes)
                .HasForeignKey(pt => pt.PostTypeId);

            modelBuilder.Entity<TaxonomyPostType>().HasData(
                new TaxonomyPostType
                {
                    PostTypeId = 1,
                    TaxonomyId = 1
                },
                new TaxonomyPostType
                {
                    PostTypeId = 1,
                    TaxonomyId = 2
                },
                new TaxonomyPostType
                {
                    PostTypeId = 1,
                    TaxonomyId = 3
                },
                new TaxonomyPostType
                {
                    PostTypeId = 1,
                    TaxonomyId = 4
                },
                new TaxonomyPostType
                {
                    PostTypeId = 2,
                    TaxonomyId = 2
                },
                new TaxonomyPostType
                {
                    PostTypeId = 2,
                    TaxonomyId = 3
                },
                new TaxonomyPostType
                {
                    PostTypeId = 2,
                    TaxonomyId = 4
                },
                new TaxonomyPostType
                {
                    PostTypeId = 3,
                    TaxonomyId = 1
                },
                new TaxonomyPostType
                {
                    PostTypeId = 3,
                    TaxonomyId = 2
                },
                new TaxonomyPostType
                {
                    PostTypeId = 3,
                    TaxonomyId = 4
                }
                );
        }

        public static void Post(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
               .HasOne(p => p.PostType)
               .WithMany(pt => pt.Posts);

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    PostTypeId = 1,
                    PostTitle = "THE TOP 20 HIGHEST-PAID CS:GO ESPORTS PLAYERS IN THE WORLD",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "This list indicates the top 20 highest-paid Counter-Strike: Global Offensive players in the world. It considers only earnings from professional esports tournaments.",
                    Details = "<p>CS:GO is one of the games with the largest number of esports events. From its release, over 69 million dollars have been awarded in 3858 tournaments, and the previous iterations of the game (Counter-Strike 1.6 and Counter-Strike: Source) handed out 15 million dollars in 1200 tournaments from 2000 to 2013.\r\n\r\nEvery year, the best pro players in the world take part at the CS:GO Major Championships: Valve-sponsored events with a prize pool of $1,000,000 USD. There are also Minor Championships with a monetary prize of $50,000 that act as qualifiers for the Major. The minors are separated in 4 regions: Americas, Asia, CIS, and Europe.\r\n\r\nThe prize pool of the Majors can’t be compared to The International (Valve-sponsored Dota 2 event), but the most popular CS:GO players and teams are able to earn a huge additional income via the tournament stickers sold in-game during each Major.</p><p>#\tNickname\tName\tCountry\tEarnings\r\n1\tdupreeh\tPeter Rasmussen\tDenmark\t$1,772,722\r\n2\tXyp9x\tAndreas Højsleth\tDenmark\t$1,771,621\r\n3\tdev1ce\tNicolai Reedtz\tDenmark\t$1,737,223\r\n4\tgla1ve\tLukas Rossander\tDenmark\t$1,602,084\r\n5\tMagisk\tEmil Reif\tDemark\t$1,366,181\r\n6\tStewie2k\tJakey Yip\tUnited States\t$1,076,740\r\n7\tTACO\tEpitácio de Melo\tBrazil\t$1,062,989\r\n8\tFalleN\tGabriel Toledo\tBrazil\t$1,059,070\r\n9\tfer\tFernando Alvarenga\tBrazil\t$1,053,170\r\n10\tcoldzera\tMarcelo David\tBrazil\t$1,002,401\r\n11\tNAF\tKeith Markovic\tCanada\t$972,165\r\n12\tkarrigan\tFinn Andersen\tDenmark\t$945,035\r\n13\tnitr0\tNick Cannella\tUnited States\t$920,151\r\n14\tELiGE\tJonathan Jablonowski\tUnited States\t$920,096\r\n15\tolofmeister\tOlof Kajbjer\tSweden\t$876,761\r\n16\tJW\tJesper Wecksell\tSweden\t$869,960\r\n17\tflusha\tRobin Rönnquist\tSweden\t$849,868\r\n18\tKRiMZ\tFreddy Johansson\tSweden\t$840,023\r\n19\tTwistzz\tRussel Van Dulken\tCanada\t$824,776\r\n20\tGuardiaN\tLadislav Kovács\tSlovakia\t$798,520</p>",
                    Image = "Astralis+won+FACEIT+London+Major+2018.jpg"
                },
                new Post
                {
                    PostId = 2,
                    PostTypeId = 1,
                    PostTitle = "CS:GO RANK DISTRIBUTION AND PERCENTAGE OF PLAYERS",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = " realistic rank distribution in CS:GO - updated monthly. Find out the percentage of players by rank and the true value of your skill.",
                    Details = "Matchmaking update and recalibration\r\nOn August 2nd, 2022, Valve released a big update to the CS:GO’s matchmaking system that affected all the players globally.\r\n\r\nWhen you launch CS:GO, you’ll notice that your Skill Group is not displayed–you’ll have to win one more match to reveal your Skill Group. Most of you will notice a change to your Skill Group, but some of you may find that you were already in the right place.\r\n\r\n— Valve\r\n\r\nPreviously, smaller regions had a bottom-heavy distribution, while Europe (the most populated one) had a top-heavy one. Now it should feel harder to rank up in Europe because the players in the top half of the curve have been redistributed. Instead, in North America matchmaking quality should be improved as before there was a high skill gap among players at mid-ranks.\r\n\r\nThere is certainly room for improvements, but Valve did a good job with the new rank distribution and matchmaking algorithm.",
                    Image = "CSGO+rank+distribution+Europe+August+2022.jpg"
                },
                new Post
                {
                    PostId = 3,
                    PostTypeId = 1,
                    PostTitle = "England face Pakistan in T20 series decider as they get knockout vibes ahead of World Cup",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "even-match T20I series between Pakistan and England to be settled in Lahore on Sunday; watch on Sky Sports Cricket from 3pm ahead of the first ball at 3.30pm; Phil Salt blazed 88 from 41 balls last time out as England won sixth match by eight wickets",
                    Details = "After a series that has swayed one way and then the other, the two teams are locked at 3-3 after six of the seven games - although England should arguably have sewn up the silverware already.\r\n\r\nBungled run chases in the fourth and fifth matches in pursuit of modest totals cost them and left them needing to win Friday's penultimate fixture, also in Lahore, to keep the series alive.",
                    Image = "engvspak.jpg"
                },
                new Post
                {
                    PostId = 4,
                    PostTypeId = 1,
                    PostTitle = "Indonesia: At least 174 people killed after riot at football match",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Thousands of Arema supporters invaded the pitch and threw bottles and other missiles at players and football officials after their side's first home defeat by a rival club in 23 years, leading to clashes and the use of a crowd control chemical banned at stadiums by FIFA",
                    Details = "At least 174 people have been killed in a riot at a football match in Indonesia, most of whom were trampled to death after police fired tear gas, in one of the world's worst sporting disasters.\r\n\r\nAngry at their team's first home defeat by the rival club in 23 years, thousands of Arema supporters invaded the pitch and threw bottles and other missiles at players and football officials.\r\n\r\nClashes spread outside the stadium where at least five police vehicles were overturned and set on fire.\r\n\r\nRiot police responded by firing tear gas, including towards the stadium's stands, sparking panic among the crowd.\r\n\r\nTear gas is banned at football stadiums by the international governing body FIFA.\r\n\r\n\"The football world is in a state of shock following the tragic incidents that have taken place in Indonesia at the end of the match between Arema FC and Persebaya Surabaya at the Kanjuruhan Stadium,\" FIFA president Gianni Infantino said.\r\n\r\n\"This is a dark day for all involved in football and a tragedy beyond comprehension. I extend my deepest condolences to the families and friends of the victims who lost their lives following this tragic incident.\r\n\r\n\"Together with FIFA and the global football community, all our thoughts and prayers are with the victims, those who have been injured, together with the people of the Republic of Indonesia, the Asian Football Confederation, the Indonesian Football Association, and the Indonesian Football League, at this difficult time.\"\r\n\r\nSome people were suffocated and others trampled as hundreds ran to the exit in a bid to escape the chemical.",
                    Image = "skysports-kanjuruhan-stadium_5916985.jpg"
                },
                new Post
                {
                    PostId = 5,
                    PostTypeId = 1,
                    PostTitle = "Russia-Ukraine war: List of key events, day 221",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "As the Russia-Ukraine war enters its 221st day, we take a look at the main developments.",
                    Details = "Diplomacy\r\nRussia failed to win enough votes for re-election to the United Nations aviation agency’s governing council, in a boost for Western powers that want to hold Moscow accountable following its invasion of Ukraine.\r\nGermany will deliver the first of four advanced IRIS-T air defence systems to Ukraine in the coming days to help ward off drone attacks, defence minister Christine Lambrecht said during an unannounced visit to Odesa.\r\nZaporizhzhia nuclear plant\r\nA Russian patrol detained the director general of Ukraine’s Russian-occupied Zaporizhzhia nuclear power plant, the state-owned company in charge of the plant said. The UN nuclear watchdog said Russia had confirmed the move.\r\nInternational Atomic Energy Agency chief Rafael Grossi is expected to hold talks in Moscow and Kyiv in the coming days on the creation of a protection zone around the Russian-held plant, the UN watchdog said.\r\nGas flows\r\nItaly’s Eni said it would not receive any of the gas it had requested from Russia’s Gazprom for delivery on Saturday, but the firms said they were working to fix this.\r\nGreece and Bulgaria started the commercial operation of a long-delayed gas pipeline that will help decrease southeast Europe’s dependence on Russian gas and boost energy security.\r\nThe Danish Energy Agency says one of two ruptured natural gas pipelines in the Baltic Sea appears to have stopped leaking gas.",
                    Image = "2022-10-01T221800Z_1690564228_RC2HSW9FAIYV_RTRMADP_3_UKRAINE-CRISIS-LYMAN-CONTROL-UGC.jpg"
                },
                new Post
                {
                    PostId = 6,
                    PostTypeId = 1,
                    PostTitle = "CRIME",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Fox News offers up-to-the-second crime coverage using our unmatched resources to keep you informed on everything from news about notorious criminals, brave law enforcement officers and their beats, the latest homicides and robberies, and the most intriguing court cases. Be the first to know as law enforcement conduct manhunts, investigate shootings, and make high-profile arrests.",
                    Details = "We’ll see you in court\r\nWant to found out the latest on a big trial? Fox News has all of the updates on court proceedings, jury verdicts, and all of the drama surrounding some of the most high-profile court cases in the country. Watch events unfold in real time with our live blog and in-court coverage of the most talked about criminal investigations in America.\r\n\r\nBreaking crime news\r\nFox News' staff of journalists are dedicated to getting you the most compelling crime coverage in America with the most accurate and constantly updated information you will find in digital media. With our phone app, you can even get instant notifications on breaking crime news, and watch breaking news as it happens, wherever you are.",
                    Image = "Crime-scene.jpg"
                },
                new Post
                {
                    PostId = 7,
                    PostTypeId = 2,
                    PostTitle = "STATE OF THE UNITED STATES: BIDEN’S AGENDA IN THE BALANCE",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Where the United States was a year ago\r\n\r\nIn January 2021 alone, a deadly insurrection overtook the US Capitol for the first time in US history, a record 96,654 Americans died from COVID-19, and Joseph R. Biden Jr became the 46th president of the United States.\r\n\r\nA few weeks later the United States Studies Centre (USSC) published its inaugural State of the United States, with the theme “An evolving alliance agenda.” Key elements of that report were:",
                    Details = "\r\nPredicting that as much as Australia might have feared becoming a target of the Biden administration’s climate agenda, US political realities would “limit broader congressional legislation on climate change” and that such differences would “not in any way threaten the deep fundamental relationship between the two countries” because the administration’s efforts would mostly be limited to executive orders and rhetoric. This insight has proven correct.\r\nCautioning that trade would “not be an urgent priority for the administration relative to domestic issues” since actualised by the Biden administration leaving intact much of the Trump administration’s protectionist and inward-focused trade policies.\r\nUrging Australia to pursue “innovative ways to advance defence industry integration with the United States, including by coordinating with Canada and the United Kingdom” — the sort of integration now sought through the AUKUS agreement.\r\nWarning that ever-deepening political polarisation would constrain much of the Biden administration’s ambitious agenda to a few key areas: an infrastructure package as well as domestic and defence investments, which help the United States compete with and better address the China challenge.1\r\nWhen asked at the launch event for State of the United States in March 2021 how the US Government envisioned a pathway for an ambitious Biden administration agenda amid such overwhelming political unrest, the State Department’s Deputy Assistant Secretary of State Atul Keshap posited that, “America is a society that is constantly innovating and reinventing itself. We’re kind of like that wobble doll, where you punch it and then it sort of wobbles back at you. There’s a lot of resiliency.”2\r\n\r\nKeshap’s optimism mirrors that of Joe Biden himself, who famously said while campaigning for president in 2019 that Republicans would have an “epiphany” and turn away from Donald Trump once he was out of office.3\r\n\r\nAlas, our analysis leads us to a different conclusion, and one with some bracing implications for Australian policymakers and strategic thinkers.\r\n\r\n",
                    Image = "scott-morrison-joe-biden-team.jpg"
                },
                new Post
                {
                    PostId = 8,
                    PostTypeId = 2,
                    PostTitle = "THREATS TO AND OPPORTUNITIES FOR US ECONOMIC AND TECHNOLOGICAL POWER",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Overview\r\nby Dr Stephen Kirchner\r\n\r\nThe Biden administration came to office with an ambitious domestic economic agenda, exemplified by the largest ever peacetime federal spending and budget deficits in its first year. While the big spending bills the administration proposed — like the American Jobs Plan and the American Families Plan — are indicative of the administration’s determination to extend a strong domestic economic recovery from the pandemic, the fact that much of the legislation has yet to pass highlights many of the domestic political and economic constraints on the administration’s agenda.\r\n\r\nMajor spending bills have been held up as the administration tries to manage competing demands from the Democratic Party’s progressive wing and its conservatives like West Virginia Senator Joe Manchin. The magnitude of the proposed spending is a challenge from the standpoint of state capacity, with long timelines separating legislation from the delivery of new programs on the ground. As USSC Non-Resident Fellow Jennifer Jackett’s review of the measures proposed under the Innovation and Competition Act and the America Competes Act suggests, the US political system continually puts the brakes on further practical action.",
                    Details = "The administration’s approach relies heavily on throwing money at perceived shortfalls in US industrial and technological capacity rather than removing structural impediments on the US innovation ecosystem. The bipartisan embrace of industrial policy, symbolised best in the over two-thirds Senate support for the ‘anti-China bill,’ the Innovation and Competition Act, has yet to show that it can transcend the pitfalls of partisan politics and domestic economic rent-seeking.\r\n\r\nBiden’s economic agenda is also inwardly, rather than outwardly, focused with domestic economic objectives prioritised over international economic engagement. In particular, new trade agreements are for the most part seen as a non-starter, lacking congressional support or presidential leadership. US allies, keen to see Biden return to the international economic rule-making space vacated by the Trump administration, will have to settle for more ad hoc and less ambitious forms of economic cooperation.\r\n\r\nWHILE THE BIG SPENDING BILLS PROPOSED ARE INDICATIVE OF THE ADMINISTRATION’S DETERMINATION TO EXTEND A STRONG DOMESTIC ECONOMIC RECOVERY FROM THE PANDEMIC, THE FACT THAT MUCH OF THE LEGISLATION HAS YET TO PASS HIGHLIGHTS MANY OF THE DOMESTIC POLITICAL AND ECONOMIC CONSTRAINTS ON THE ADMINISTRATION’S AGENDA.\r\nIssues of supply chain security loom large for the United States and its allies. The global outbreak of inflationary pressures on the back of supply chain bottlenecks has underscored the issues of supply chain resilience brought to the fore by the COVID-19 pandemic. The secular decline in the prices of durable goods has undergone a dramatic reversal, with US inflation at its highest rate since 1982.25\r\n\r\nInflationary pressures and the shortfalls in supply are mostly due to dramatic shifts in demand brought about by changed consumptions patterns induced by the pandemic. The slow supply response to these demand shifts was also exacerbated by under-investment in new production capacity and related infrastructure brought about by the 2020 pandemic downturn.\r\n\r\nOn balance, global supply chains did well to pivot in response to these demand shifts by increasing output as quickly as they did. No supply chain configuration, regardless of how domiciled, could have easily accommodated such massive demand shifts. Rising prices are already inducing supply responses that will ultimately see a return to pre-pandemic disinflationary pressures.\r\n\r\nOne example of this is the US supply of semiconductors is not only ensnared in this pandemic-induced shift in demand but also a key battleground in the strategic rivalry between the United States and China, as Jennifer Jackett’s contribution makes clear. As with the US response to trade competition with Japan in the 1980s, recently proposed subsidies for domestic chip manufacturing aim not only to address temporary supply shortfalls but to maintain technological dominance over China’s emerging chip sector and provide supply chain security for the critical tech sector.\r\n\r\nThe Biden administration’s so-called ‘foreign policy for the middle class,’ referred to extensively by key members of his administration, suggests the same domestic orientation as Trump’s ‘America First.’ Accordingly, integrating its domestic economic agenda with industrial and technological cooperation with allies will remain one of the administration’s biggest challenges going forward.\r\n\r\nIt is also a form of policy integration that the US Government is poorly equipped to deliver. US state capacity remains highly fragmented between domestic and international policymaking silos. Even where the international-facing arms of the US Government may want to progress alliance cooperation, the domestic-facing arms will pull attention back to domestic policy issues and priorities.\r\n\r\n",
                    Image = "america-competes-act.jpg"
                },
                new Post
                {
                    PostId = 9,
                    PostTypeId = 2,
                    PostTitle = "Pep Guardiola: 'Manchester City have future strategy without me'",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Manchester City manager Pep Guardiola believes the club will be able to progress after his departure because it has a \"strategy\" in place.\r\n\r\nThe 51-year-old is in the final year of his contract, though he has given no indication he intends to leave.\r\n\r\nSince joining City from Bayern Munich in 2016 on an initial three-year deal, Guardiola has signed two contract extensions.\r\n\r\n\"The club knows exactly what is the target, the next step,\" he said when asked about City's future should he leave.",
                    Details = "Up for debate: Would Man City fill a Manchester XI in post-Ferguson era?\r\n\"There will be zero problem, I am 100% convinced. They know what is the strategy, what they have to do for right now, the day after tomorrow, after the World Cup, next season and the next season.\r\n\r\n\"When the club depends on one person we have problems, as the club is not solid, isn't stable.\r\n\r\n\"The foundations of the club come from many and if the club just depends on 'Pep' it is because we have not done really well in this period.\"\r\n\r\nDuring his time in charge, Guardiola has won nine major trophies with Manchester City, including four Premier League titles.\r\n\r\nThey became the first English men's team to win the domestic treble - Premier League, Carabao Cup and FA Cup - in 2019.\r\n\r\nThis season they are chasing a fifth league title in six campaigns, having retained the trophy for a second successive year in 2021-22.\r\n\r\n\"I never buy a player, I never sell a player, it's not my money,\" added Guardiola. \"It is the club - 'club' is the most important word and every decision we make is thinking about the club. Today, the day after and for the future.\r\n\r\n\"The club knows the drill really well, the type of players that we want to play with me and without me.\"",
                    Image = "_126924050_gettyimages-1243598126.jpg"
                },
                new Post
                {
                    PostId = 10,
                    PostTypeId = 2,
                    PostTitle = "Brazil election: How the famous yellow football shirt has become politicised",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "When the much-awaited Brazil 2022 World Cup shirt was released in August, student João Vitor Gonçalves de Oliveira rushed to get his hands on the kit.\r\n\r\nThe 20-year-old went to the nearest store, grabbed the famous yellow and green top and took it to the till, where he was met with an excited smile.\r\n\r\n\"The shop owner assumed I support the current government because I was buying the shirt, and started to rage against left-wing candidate Lula,\" João tells the BBC.\r\n\r\nJoão does not support the government of Jair Bolsonaro, who is standing for re-election on Sunday. But buying the shirt, he realised in the store, could make people think he did.\r\n\r\nIn order to avoid confrontation, João pretended to be a Bolsonaro supporter. It was another sign that the yellow and green shirt - made famous by Pele, Ronaldo, and many others - has become a symbol of a divided nation.",
                    Details = "\"The shirt has become stained with political meaning since 2014,\" says Mateus Gamba Torres, a history professor at the University of Brasília.\r\n\r\nEight years ago, millions of Brazilians took to the streets to protest against the then-President, Dilma Rousseff, dressed in the colours of the flag as they demanded the left-winger's impeachment.\r\n\r\nThen in 2018, the colours were again used by the current president - far-right Jair Bolsonaro.\r\n\r\nThis year too, green, yellow and blue are the key colours at Mr Bolsonaro's rallies, with people wearing T-shirts, the national flag and accessories.\r\n\r\n\"The green and yellow shirt has become a symbol of those related to Bolsonaro's government,\" Mr Gamba Torres says, \"which means a good part of the population no longer identify with it.\"\r\n\r\nFormer Brazilian president Lula at a campaign rally in Manaus.\r\nFormer Brazilian president Lula standing in front of the Brazilian flag on-screen at a campaign rally in Manaus\r\nJoão's encounter with the shop owner is not the only reason he is now hesitant to talk politics. In Brazil, political disputes can seemingly get deadly.\r\n\r\nIn July, Marcelo Aloizio de Arruda - a supporter of former president and left-wing candidate Luiz Inácio Lula da Silva - was shot dead at his 50th birthday party, allegedly by a police officer shouting in support of right-wing President Bolsonaro.\r\n\r\nBefore he died, Mr Arruda retaliated and shot his alleged attacker - who spent some time in hospital before being sent to prison, where he awaits trial.\r\n\r\nAnd on 9 September, 44-year-old Benedito Cardoso dos Santos was allegedly killed by a colleague, following a heated political discussion between the two. The 22-year-old suspect remains in police custody.\r\n\r\nTech programmer Ruy Araújo Souza Júnior, 43, tells BBC News he will only wear the shirt at home, to avoid being mistaken for a Bolsonaro supporter.\r\n\r\nIf ex-President Lula wins the election, he hopes the shirt will \"once again unite us and symbolise true love of our country, not a political party\".\r\n\r\nLeft-wing candidate Lula has focused on \"reclaiming\" the flag. Several of his supporters, such as singer Ludmilla, international star Anitta, and rapper Djonga, have made a point of wearing the shirt during their performances.\r\n\r\nDjonga, who was part of Nike's official campaign for the Brazilian World Cup kit, told a crowd at one concert that wearing the shirt in public was an act of protest.\r\n\r\n\"They [Bolsonaro supporters] think everything is theirs, they appropriate the meaning of family, they appropriate our national anthem, they appropriate everything,\" he said. \"But here's the truth: everything is ours, nothing is theirs.\"\r\n\r\nBut it's not just Mr Bolsonaro's opponents who are wary of wearing the shirt.\r\n\r\n\"I'm a patriot and right-wing. I really want to vote wearing my yellow shirt,\" says Bolsonaro supporter Alessandra Passos, 41.\r\n\r\nBut due to the tense environment between voters, she says, she is \"afraid to wear it on voting day\".",
                    Image = "_126896636_richarlison_getty.jpg"
                },
                new Post
                {
                    PostId = 11,
                    PostTypeId = 3,
                    PostTitle = "What Made Left 4 Dead Special, According To The Devs Making Games Like It",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Left 4 Dead is a trailblazing game still remembered fondly today. GameSpot spoke with several teams making games like it to try and figure out what makes it timeless.",
                    Details = "I love Left 4 Dead, and I tend to enjoy many of the games it's clearly inspired over the years --and there are a lot. Sensing there's no end in sight to games inspired by Valve's seminal co-op horde shooter, even as Left 4 Dead 3 doesn't appear to be likely itself, I wanted to find out what makes Left 4 Dead such a milestone. More importantly, I wanted to hear it from the teams that have taken the baton from Valve and carried it in different directions, adding their own touches to the time-tested formula but always nodding back to that landmark original game.\r\n\r\n\"It keeps the right things simple,\" Chet Faliszek told me earlier this month about Left 4 Dead. Faliszek worked on both Left 4 Dead games at Valve, and spends these days at his new studio, Stray Bombay, building a new L4D-inspired game: The Anacrusis. The co-op shooter places a lot of the foundational L4D gameplay in a sci-fi setting akin to the original Star Trek. \"I still see games that greet you with confusing interfaces or a forced tutorial that gets in the way of inviting a friend who is new into your game. Left 4 Dead gets out of the way and lets you jump into the game and have some fun.\"\r\n\r\nFaliszek was addressing a question I posed to his and four other teams, each of them having worked on games that can reasonably be called Left 4 Dead descendents. Around the world, games like Systemic Reaction's Second Extinction, Saber Interactive's World War Z, Fatshark's Warhammer: Vermintide and Darktide, and Ghost Ship Games' Deep Rock Galactic have roots that trail back to Left 4 Dead, some more than others, but all of them are undeniably inspired by it. His response was not uncommon among the group of devs I spoke to. In my interviews with the five studios, each team repeatedly cited two assets that Left 4 Dead maintains to this day: simplicity and replayability.\r\n\r\n\"Initially [World War Z] was supposed to be a completely different game that didn’t have any resemblance to L4D,\" Saber Lead Game Designer Dmitry Grigorenko told me. \"Funny thing is, when you make a co-op shooter game about zombies, there aren’t many ways that you can go. Somewhere in the middle of the development after another playtest we sat down together as a team and said, 'Okay, our game is beginning to look a lot like L4D.''' Grigorenko said the team began to study how Left 4 Dead's famous AI Director behaved so that Saber could implement something similar.\r\n\r\nThis was a problem that grew in scope for the team, as it had to authentically capture the look of its source material, including the mountainous swarms of undead that far outnumber the horde sizes in Left 4 Dead. \"Adding more zombies sounds simple on paper, but our zombie swarm system is incredibly complex. Zombies need to behave like a real crowd; you cannot achieve that just by increasing numbers. AI, animation and level design needs to work very well together to make sure that these sequences look like scenes in the movie.\"",
                    Image = "left4dead.jpg"
                },
                new Post
                {
                    PostId = 12,
                    PostTypeId = 3,
                    PostTitle = "The Complete God of War Timeline Explained!",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "The God of War franchise has a sprawling timeline that interweaves its Great Greek Tragedy across 9 games, and 2 wildly distinct mythologies. But how does it all tie together?",
                    Details = "This video breaks down the franchise chronologically, charting the story of Kratos from a hot headed youth, through to a captain in the Spartan army all before his grand odyssey through the Greek and Norse mythologies.\r\n\r\nWith God of War Ragnarök set to further slide the franchise’s anti-hero, Kratos, into a mythological mire, what better time to dive back into the Ghost of Sparta’s saga of gods and monsters.",
                    Image = "gow.jpg"
                },
                new Post
                {
                    PostId = 13,
                    PostTypeId = 3,
                    PostTitle = "October 2022 General Conference News and Announcements",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "General conferences of The Church of Jesus Christ of Latter-day Saints take place every six months.",
                    Details = "The five sessions of the October 2022 conference (October 1–2) is being broadcast live from Temple Square in Salt Lake City in 70 languages. This page provides a summary of the conference’s sermons, news and announcements.\r\n\r\nGeneral Conference News\r\n\r\nWas the Prophet Seated While He Spoke? President Nelson Explains\r\nChurch Publishes New Youth Guide\r\nEight General Authority Seventies Released; Six Area Seventies Called\r\nSession Summaries\r\n\r\nSaturday Morning\r\nSaturday Afternoon\r\nSaturday Evening\r\nSunday Morning\r\nSunday Afternoon\r\nResources\r\n\r\nHow to Watch General Conference\r\nThe October 2022 World Report\r\nInvitations President Nelson Has Given Since He Became Prophet\r\nGeneral Conference Activities for Children and Youth\r\nWhat Does It Take to Produce General Conference?",
                    Image = "20221001_095504_CBell_CMB_4463.jpg"
                },
                new Post
                {
                    PostId = 14,
                    PostTypeId = 3,
                    PostTitle = "FDA Roundup: September 30, 2022 ",
                    CreationDate = "10/10/2022 10:00 AM",
                    Summary = "Today, the U.S. Food and Drug Administration is providing an at-a-glance summary of news from around the agency:",
                    Details = "Today, the FDA published the FDA Voices: “FDA Continues Important Work on Substance Use and Overdose Prevention Efforts,” by Robert M. Califf, M.D., Commissioner of Food and Drugs. The National Academies for Science, Engineering, and Medicine (NASEM) report \"Pain Management and the Opioid Epidemic,\" contained recommendations for the FDA’s consideration, as well as broader recommendations for federal agencies, state and local governments, and health-related organizations. As we continue to prioritize our substance use and overdose prevention efforts, the NASEM report has been and will remain an important source to consider in our decision making.\r\nToday, the FDA published a Constituent Update to remind owners, operators, or agents in charge of a domestic or foreign food facility engaged in manufacturing/processing, packing, or holding food for consumption by humans or animals in the U.S, to register the facility with FDA or to renew their FDA registration between October 1 and December 31, 2022. \r\nOn Thursday, the FDA approved SpectoGard, the first generic spectinomycin sulfate injectable solution for the treatment of bovine respiratory disease (pneumonia). SpectoGard contains the same active ingredient (spectinomycin sulfate) in the same concentration and dosage form as the approved brand name drug product, Adspec, which was first approved in January 1998. SpectoGard is only available by prescription because a veterinarian’s expertise is required to determine if SpectoGard is an appropriate treatment for cattle. SpectoGard is sponsored by Bimeda Animal Health Ltd.\r\nOn Wednesday, the FDA issued a warning letter jointly with the Federal Trade Commission to Bespoke Apothecary LLC for selling unapproved and misbranded COVID kit and Post Virus Recovery Herbal Tea products as drugs for use in treating or preventing COVID-19. Consumers concerned about COVID-19 should consult with their health care provider.\r\nOn Wednesday, the FDA approved Simplera Otic Solution, the first generic animal drug product that has single dose treatment with a 30-day duration of effect for otitis externa (outer ear infection) in dogs. Simplera Otic Solution is a prescription product that contains the same active ingredients in the same concentration and dosage form as the approved brand name drug product, Claro, which FDA first approved in September 2015. Simplera is sponsored by Vetoquinol USA, Inc.\r\nOn Tuesday, the FDA announced updates to its COVID-19 test policy to address public health testing needs during this phase of the COVID-19 public health emergency. Over the last two years more than 400 COVID-19 tests have been granted emergency use authorization and there are generally enough at-home tests, tests that can be used at the point-of-care such as health clinics, and laboratory-based tests to meet testing needs. The FDA is revising its COVID-19 test policy to encourage most COVID-19 test developers to pursue a traditional premarket review pathway for their tests, rather than emergency use authorization. The FDA intends to prioritize its review of emergency use authorization requests on COVID-19 diagnostic tests that are likely to have a significant public health benefit or are likely to fulfill an unmet need. This could include novel technologies like the use of breath samples, or unique features like the ability of a test to detect a new SARS-CoV-2 virus variant. The FDA actions include: \r\nReissuing the Policy for Coronavirus Disease-2019 Tests During the Public Health Emergency (Revised).\r\nUpdating the FAQs on Testing for SARS-CoV-2.\r\nCOVID-19 testing updates:\r\nAs of today, 437 tests and sample collection devices are authorized by the FDA under emergency use authorizations (EUAs). These include 300 molecular tests and sample collection devices, 85 antibody and other immune response tests, 51 antigen tests, and 1 diagnostic breath test. There are 79 molecular authorizations and 1 antibody authorization that can be used with home-collected samples. There is 1 EUA for a molecular prescription at-home test, 2 EUAs for antigen prescription at-home tests, 19 EUAs for antigen over-the-counter (OTC) at-home tests, and 3 for molecular OTC at-home tests.\r\nThe FDA has authorized 31 antigen tests and 8 molecular tests for serial screening programs. The FDA has also authorized 1124 revisions to EUA authorizations. ",
                    Image = "20221001_075548_CBell_110_1664633642670_photo_optimized.jpg"
                }
                );
        }

        public static void PostTerm(this ModelBuilder builder)
        {
            builder.Entity<PostTerm>()
                .HasKey(pt => new { pt.PostId, pt.TermId });

            builder.Entity<PostTerm>()
                .HasOne(pt => pt.Term)
                .WithMany(t => t.PostTerms)
                .HasForeignKey(pt => pt.TermId);

            builder.Entity<PostTerm>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTerms)
                .HasForeignKey(pt => pt.PostId);

            builder.Entity<PostTerm>().HasData(
                new PostTerm
                {
                    PostId = 1,
                    TermId = 2,
                },
                new PostTerm
                {
                    PostId = 1,
                    TermId = 3,
                },
                new PostTerm
                {
                    PostId = 2,
                    TermId = 1,
                },
                new PostTerm
                {
                    PostId = 2,
                    TermId = 3,
                },
                new PostTerm
                {
                    PostId = 3,
                    TermId = 16,
                },
                new PostTerm
                {
                    PostId = 3,
                    TermId = 13,
                },
                new PostTerm
                {
                    PostId = 3,
                    TermId = 14,
                },
                new PostTerm
                {
                    PostId = 3,
                    TermId = 4,
                },
                new PostTerm
                {
                    PostId = 4,
                    TermId = 15,
                },
                new PostTerm
                {
                    PostId = 4,
                    TermId = 7,
                },
                new PostTerm
                {
                    PostId = 4,
                    TermId = 6,
                },
                new PostTerm
                {
                    PostId = 5,
                    TermId = 7,
                },
                new PostTerm
                {
                    PostId = 5,
                    TermId = 9,
                },
                new PostTerm
                {
                    PostId = 5,
                    TermId = 11,
                },
                new PostTerm
                {
                    PostId = 5,
                    TermId = 17,
                },
                new PostTerm
                {
                    PostId = 5,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 6,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 6,
                    TermId = 7,
                },
                new PostTerm
                {
                    PostId = 6,
                    TermId = 12,
                },
                new PostTerm
                {
                    PostId = 7,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 7,
                    TermId = 7,
                },
                new PostTerm
                {
                    PostId = 7,
                    TermId = 17,
                },
                new PostTerm
                {
                    PostId = 7,
                    TermId = 12,
                },
                new PostTerm
                {
                    PostId = 8,
                    TermId = 12,
                },
                new PostTerm
                {
                    PostId = 8,
                    TermId = 7,
                },
                new PostTerm
                {
                    PostId = 9,
                    TermId = 6,
                },
                new PostTerm
                {
                    PostId = 9,
                    TermId = 18,
                },
                new PostTerm
                {
                    PostId = 10,
                    TermId = 6,
                },
                new PostTerm
                {
                    PostId = 10,
                    TermId = 19,
                },
                new PostTerm
                {
                    PostId = 10,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 11,
                    TermId = 20,
                },
                new PostTerm
                {
                    PostId = 11,
                    TermId = 1,
                },
                new PostTerm
                {
                    PostId = 12,
                    TermId = 1,
                },
                new PostTerm
                {
                    PostId = 12,
                    TermId = 21,
                },
                new PostTerm
                {
                    PostId = 13,
                    TermId = 12,
                },
                new PostTerm
                {
                    PostId = 13,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 14,
                    TermId = 8,
                },
                new PostTerm
                {
                    PostId = 14,
                    TermId = 12,
                }
                );
        }
    }
}
