using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Seeding
{
    public class ProductSeeder:ISeeder<Product>
    {
        private static readonly List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                 name = "Shining",
                 description = "The Shining is a 1977 horror novel by American author Stephen King. It is King's third published novel and first hardback bestseller; its success firmly established King as a preeminent author in the horror genre. The setting and characters are influenced by King's personal experiences, including both his visit to The Stanley Hotel in 1974 and his struggle with alcoholism. The novel was adapted into a 1980 film of the same name. The book was followed by a sequel, Doctor Sleep, published in 2013, which was adapted into a film of the same name.",
                 price = 380,
                 numberPages = 447,
                 value = 100,
                 categoryId = 1,
                 mainPhotoId = 1,
                 bindingId = 1

             }, new Product
             {
                 Id = 2,
                 name = "Doctor Sleep",
                 description = "Doctor Sleep is a 2013 horror novel by American writer Stephen King and the sequel to his 1977 novel The Shining. The book reached the first position on The New York Times Best Seller list for print and ebook fiction (combined), hardcover fiction, and ebook fiction. Doctor Sleep won the 2013 Bram Stoker Award for Best Novel.",
                 price = 420,
                 numberPages = 564,
                 value = 100,
                 categoryId = 1,
                 mainPhotoId = 2,
                 bindingId = 1
             }, new Product
             {
                 Id = 3,
                 name = "Psycho",
                 description = "Psycho is a 1959 horror novel by American writer Robert Bloch. The novel tells the story of Norman Bates, a caretaker at an isolated motel who struggles under his domineering mother and becomes embroiled in a series of murders. The novel is considered Bloch's most enduring work and one of the most influential horror books of the 20th century.",
                 price = 320,
                 numberPages = 185,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 3,
                 bindingId = 2
             }, new Product
             {
                 Id = 4,
                 name = "Pet Sematary",
                 description = "Pet Sematary is a 1983 horror novel by American writer Stephen King. The novel was nominated for a World Fantasy Award for Best Novel in 1986,[1] and adapted into two films: one in 1989 and another in 2019. In November 2013, PS Publishing released Pet Sematary in a limited 30th-anniversary edition.",
                 price = 420,
                 numberPages = 373,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 4,
                 bindingId = 1
             }, new Product
             {
                 Id = 5,
                 name = "It",
                 description = "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and his 17th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey. It primarily appears in the form of Pennywise the Dancing Clown to attract its preferred prey of young children.",
                 price = 820,
                 numberPages = 1138,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 5,
                 bindingId = 1
             }, new Product
             {
                 Id = 6,
                 name = "Joyland",
                 description = "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original",
                 price = 820,
                 numberPages = 1138,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 6,
                 bindingId = 1
             }, new Product
             {
                 Id = 7,
                 name = "Joyland",
                 description = "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original",
                 price = 190,
                 numberPages = 288,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 7,
                 bindingId = 2
             }, new Product
             {
                 Id = 8,
                 name = "Outsider",
                 description = "The Outsider (2018) is a horror novel by the American author Stephen King. The novel was published by Scribner.",
                 price = 420,
                 numberPages = 560,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 8,
                 bindingId = 1
             }, new Product
             {
                 Id = 9,
                 name = "Outsider",
                 description = "The Outsider (2018) is a horror novel by the American author Stephen King. The novel was published by Scribner.",
                 price = 420,
                 numberPages = 560,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 9,
                 bindingId = 2
             }, new Product
             {
                 Id = 10,
                 name = "Joyland",
                 description = "Joyland is a novel by American writer Stephen King, published in 2013 by Hard Case Crime. It is King's second book for the imprint, following The Colorado Kid (2005). The first edition was released only in paperback, with the cover art created by Robert McGinnis and Glen Orbik. A limited hardcover edition followed a week later.[1][2] The novel was nominated for the 2014 Edgar Award for Best Paperback Original",
                 price = 190,
                 numberPages = 288,
                 value = 50,
                 categoryId = 1,
                 mainPhotoId = 10,
                 bindingId = 2
             }, new Product
             {
                 Id = 11,
                 name = "The Lord of the Rings",
                 description = "The Lord of the Rings is an epic[1] high-fantasy novel[a] by English author and scholar J. R. R. Tolkien. Set in Middle-earth, intended to be Earth at some distant time in the past, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.",
                 price = 720,
                 numberPages = 840,
                 value = 50,
                 categoryId = 2,
                 mainPhotoId =11,
                 bindingId = 1
             }, new Product
             {
                 Id = 12,
                 name = "Harry Potter and the Philosopher's Stone",
                 description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                 price = 380,
                 numberPages = 223,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 12,
                 bindingId = 1

             }, new Product
             {
                 Id = 13,
                 name = "Harry Potter and the Chamber of Secrets",
                 description = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
                 price = 400,
                 numberPages = 251,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 13,
                 bindingId = 1
             }, new Product
             {
                 Id = 14,
                 name = "Harry Potter and the Prisoner of Azkaban",
                 description = "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
                 price = 420,
                 numberPages = 317,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 14,
                 bindingId = 1
             }, new Product
             {
                 Id = 15,
                 name = "Harry Potter and the Goblet of Fire",
                 description = "Harry Potter and the Goblet of Fire is a fantasy novel written by British author J. K. Rowling and the fourth novel in the Harry Potter series. It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.",
                 price = 440,
                 numberPages = 636,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 15,
                 bindingId = 1
             }, new Product
             {
                 Id = 16,
                 name = "Harry Potter and the Order of the Phoenix",
                 description = "Harry Potter and the Order of the Phoenix is a fantasy novel written by British author J. K. Rowling and the fifth novel in the Harry Potter series. It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic. The novel was published on 21 June 2003 by Bloomsbury in the United Kingdom, Scholastic in the United States, and Raincoast in Canada. It sold five million copies in the first 24 hours of publication.[1] It is the longest book of the series.",
                 price = 460,
                 numberPages = 766,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 16,
                 bindingId = 1
             }, new Product
             {
                 Id = 17,
                 name = "Harry Potter and the Half-Blood Prince",
                 description = "Harry Potter and the Half-Blood Prince is a fantasy novel written by British author J.K. Rowling and the sixth and penultimate novel in the Harry Potter series. Set during Harry Potter's sixth year at Hogwarts, the novel explores the past of the boy wizard's nemesis, Lord Voldemort, and Harry's preparations for the final battle against Voldemort alongside his headmaster and mentor Albus Dumbledore.",
                 price = 480,
                 numberPages = 607,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 17,
                 bindingId = 1
             }, new Product
             {
                 Id = 18,
                 name = "Harry Potter and the Deathly Hallows",
                 description = "Harry Potter and the Deathly Hallows is a fantasy novel written by British author J. K. Rowling and the seventh and final novel of the Harry Potter series. It was released on 21 July 2007 in the United Kingdom by Bloomsbury Publishing, in the United States by Scholastic, and in Canada by Raincoast Books. The novel chronicles the events directly following Harry Potter and the Half-Blood Prince (2005) and the final confrontation between the wizards Harry Potter and Lord Voldemort.",
                 price = 500,
                 numberPages = 607,
                 value = 100,
                 categoryId = 2,
                 mainPhotoId = 18,
                 bindingId = 1
             }
    };


        public void Seed(EntityTypeBuilder<Product> builder) => builder.HasData(products);
    }
}
