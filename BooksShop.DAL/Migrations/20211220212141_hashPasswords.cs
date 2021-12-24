using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksShop.DAL.Migrations
{
    public partial class hashPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bindings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bindingType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bindings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPhotos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    price = table.Column<float>(type: "real", maxLength: 6, nullable: false),
                    numberPages = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    value = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    bindingId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    mainPhotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_bindingId",
                        column: x => x.bindingId,
                        principalTable: "Bindings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_mainPhotoId",
                        column: x => x.mainPhotoId,
                        principalTable: "MainPhotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Year" },
                values: new object[,]
                {
                    { "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f", 0, "d6ccc5b6-fe31-484b-9a50-9cb9b72934bf", null, false, "Sophia", "Beringer", false, null, null, null, "AQAAAAEAACcQAAAAEPPThESa/6dV7YayZEuUFRP3L6anPXpanbFOFX8bJatLJ+B2FKRBoM6vgXCbFaTEog==", null, false, "f6634c40-ee07-45f6-8dd0-4bae7f160ccb", false, "User3", null },
                    { "3b333929-f974-444e-a8d3-68f50a0459c0", 0, "4b7b142b-8c53-4758-add3-0946e2e3f192", null, false, "Esmaralda", "Voigt", false, null, null, null, "AQAAAAEAACcQAAAAEGMAaPeAx2pweEAwzZQ8fzVHBlNsk8tbRB9R2NNCKHlgvxeNcX6cwMKATip23SlGYw==", null, false, "d35f5d7a-bdc5-4ff9-b3e3-af5fa25dd698", false, "User1", null },
                    { "61dfb9e3-1c27-424a-9963-9586ca110220", 0, "e684d644-0070-47e1-b59d-bc0182d6d6d6", null, false, "Ostap", "Bleier", false, null, null, null, "Password2", null, false, "56a6e829-5536-479e-b00b-09eb313952fe", false, "User2", null }
                });

            migrationBuilder.InsertData(
                table: "Bindings",
                columns: new[] { "Id", "bindingType" },
                values: new object[,]
                {
                    { 1, "Hard" },
                    { 2, "Soft" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "category" },
                values: new object[,]
                {
                    { 3, "Detective" },
                    { 1, "Horror" },
                    { 2, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "MainPhotos",
                columns: new[] { "Id", "path" },
                values: new object[,]
                {
                    { 18, "hpdh.jpg" },
                    { 17, "hphbp.jpg" },
                    { 16, "hpop.jpg" },
                    { 15, "hpgf.jpg" },
                    { 14, "hppa.jpg" },
                    { 13, "hpch.jpg" },
                    { 12, "hpp.jpg" },
                    { 10, "joyland.jpg" },
                    { 9, "outsider.jpg" },
                    { 7, "joyland.jpg" },
                    { 6, "joyland.jpg" },
                    { 5, "It.jpg" },
                    { 4, "PetSematary.jpg" },
                    { 3, "Psycho.jpg" },
                    { 2, "drSleep.jpg" },
                    { 1, "shinig.jpg" },
                    { 11, "lotr.jpg" },
                    { 8, "outsider.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "bindingId", "categoryId", "description", "mainPhotoId", "name", "numberPages", "price", "value" },
                values: new object[,]
                {
                    { 1, 1, 1, "The Shining is a 1977 horror novel by American author Stephen King. It is King's third published novel and first hardback bestseller; its success firmly established King as a preeminent author in the horror genre. The setting and characters are influenced by King's personal experiences, including both his visit to The Stanley Hotel in 1974 and his struggle with alcoholism. The novel was adapted into a 1980 film of the same name. The book was followed by a sequel, Doctor Sleep, published in 2013, which was adapted into a film of the same name.", 1, "Shining", 447, 380f, 100 },
                    { 16, 1, 2, "Harry Potter and the Order of the Phoenix is a fantasy novel written by British author J. K. Rowling and the fifth novel in the Harry Potter series. It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic. The novel was published on 21 June 2003 by Bloomsbury in the United Kingdom, Scholastic in the United States, and Raincoast in Canada. It sold five million copies in the first 24 hours of publication.[1] It is the longest book of the series.", 16, "Harry Potter and the Order of the Phoenix", 766, 460f, 100 },
                    { 15, 1, 2, "Harry Potter and the Goblet of Fire is a fantasy novel written by British author J. K. Rowling and the fourth novel in the Harry Potter series. It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.", 15, "Harry Potter and the Goblet of Fire", 636, 440f, 100 },
                    { 14, 1, 2, "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.", 14, "Harry Potter and the Prisoner of Azkaban", 317, 420f, 100 },
                    { 13, 1, 2, "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.", 13, "Harry Potter and the Chamber of Secrets", 251, 400f, 100 },
                    { 12, 1, 2, "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.", 12, "Harry Potter and the Philosopher's Stone", 223, 380f, 100 },
                    { 11, 1, 2, "The Lord of the Rings is an epic[1] high-fantasy novel[a] by English author and scholar J. R. R. Tolkien. Set in Middle-earth, intended to be Earth at some distant time in the past, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.", 11, "The Lord of the Rings", 840, 720f, 50 },
                    { 10, 2, 1, "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original", 10, "Joyland", 288, 190f, 50 },
                    { 9, 2, 1, "The Outsider (2018) is a horror novel by the American author Stephen King. The novel was published by Scribner.", 9, "Outsider", 560, 420f, 50 },
                    { 8, 1, 1, "The Outsider (2018) is a horror novel by the American author Stephen King. The novel was published by Scribner.", 8, "Outsider", 560, 420f, 50 },
                    { 7, 2, 1, "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original", 7, "Joyland", 288, 190f, 50 },
                    { 6, 1, 1, "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original", 6, "Joyland", 1138, 820f, 50 },
                    { 5, 1, 1, "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and his 17th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey. It primarily appears in the form of Pennywise the Dancing Clown to attract its preferred prey of young children.", 5, "It", 1138, 820f, 50 },
                    { 4, 1, 1, "Pet Sematary is a 1983 horror novel by American writer Stephen King. The novel was nominated for a World Fantasy Award for Best Novel in 1986,[1] and adapted into two films: one in 1989 and another in 2019. In November 2013, PS Publishing released Pet Sematary in a limited 30th-anniversary edition.", 4, "Pet Sematary", 373, 420f, 50 },
                    { 3, 2, 1, "Psycho is a 1959 horror novel by American writer Robert Bloch. The novel tells the story of Norman Bates, a caretaker at an isolated motel who struggles under his domineering mother and becomes embroiled in a series of murders. The novel is considered Bloch's most enduring work and one of the most influential horror books of the 20th century.", 3, "Psycho", 185, 320f, 50 },
                    { 2, 1, 1, "Doctor Sleep is a 2013 horror novel by American writer Stephen King and the sequel to his 1977 novel The Shining. The book reached the first position on The New York Times Best Seller list for print and ebook fiction (combined), hardcover fiction, and ebook fiction. Doctor Sleep won the 2013 Bram Stoker Award for Best Novel.", 2, "Doctor Sleep", 564, 420f, 100 },
                    { 17, 1, 2, "Harry Potter and the Half-Blood Prince is a fantasy novel written by British author J.K. Rowling and the sixth and penultimate novel in the Harry Potter series. Set during Harry Potter's sixth year at Hogwarts, the novel explores the past of the boy wizard's nemesis, Lord Voldemort, and Harry's preparations for the final battle against Voldemort alongside his headmaster and mentor Albus Dumbledore.", 17, "Harry Potter and the Half-Blood Prince", 607, 480f, 100 },
                    { 18, 1, 2, "Harry Potter and the Deathly Hallows is a fantasy novel written by British author J. K. Rowling and the seventh and final novel of the Harry Potter series. It was released on 21 July 2007 in the United Kingdom by Bloomsbury Publishing, in the United States by Scholastic, and in Canada by Raincoast Books. The novel chronicles the events directly following Harry Potter and the Half-Blood Prince (2005) and the final confrontation between the wizards Harry Potter and Lord Voldemort.", 18, "Harry Potter and the Deathly Hallows", 607, 500f, 100 }
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
                name: "IX_Products_bindingId",
                table: "Products",
                column: "bindingId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_mainPhotoId",
                table: "Products",
                column: "mainPhotoId");
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bindings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MainPhotos");
        }
    }
}
