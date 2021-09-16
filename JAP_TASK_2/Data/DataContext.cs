using System;
using System.Collections.Generic;
using JAP_TASK_2.DTOs.Reporting;
using JAP_TASK_2.Models;
using Microsoft.EntityFrameworkCore;

namespace JAP_TASK_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MostSoldMoviesWithoutRatingsResult> MostSoldMoviesWithoutRatingsResults { get; set; }
        public DbSet<Top10MoviesByRatingResult> Top10MoviesByRatingResults { get; set; }
        public DbSet<Top10MoviesByScreeningsForPeriodResult> Top10MoviesByScreeningsForPeriodResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CastMembers
            var cm1 = new CastMember { Id = 1, Name = "Carrie Fisher" };
            var cm2 = new CastMember { Id = 2, Name = "Mark Hamil" };
            var cm3 = new CastMember { Id = 3, Name = "Harrison Ford" };
            var cm4 = new CastMember { Id = 4, Name = "Cole Sprouse" };
            var cm5 = new CastMember { Id = 5, Name = "Lili Reinhart" };
            var cm6 = new CastMember { Id = 6, Name = "Camila Mendes" };
            var cm7 = new CastMember { Id = 7, Name = "KJ Apa" };
            var cm8 = new CastMember { Id = 8, Name = "James Spader" };
            var cm9 = new CastMember { Id = 9, Name = "Megan Boone" };
            var cm10 = new CastMember { Id = 10, Name = "Diego Klattenhoff" };
            var cm11 = new CastMember { Id = 11, Name = "Henry Lennix" };
            var cm12 = new CastMember { Id = 12, Name = "Daisy Ridley" };
            var cm13 = new CastMember { Id = 13, Name = "Adam Driver" };
            var cm14 = new CastMember { Id = 14, Name = "Natalie Portman" };
            var cm15 = new CastMember { Id = 15, Name = "Ewan McGregor" };
            var cm16 = new CastMember { Id = 16, Name = "Liam Neeson" };
            var cm17 = new CastMember { Id = 17, Name = "Hayden Christensen" };

            var cm18 = new CastMember { Id = 18, Name = "Jared Harris" };
            var cm19 = new CastMember { Id = 19, Name = "Stellan Skarsgård" };
            var cm20 = new CastMember { Id = 20, Name = "Emily Watson" };
            var cm21 = new CastMember { Id = 21, Name = "Paul Ritter" };

            var cm22 = new CastMember { Id = 22, Name = "Úrsula Corberó" };
            var cm23 = new CastMember { Id = 23, Name = "Álvaro Morte" };
            var cm24 = new CastMember { Id = 24, Name = "Itziar Ituño" };
            var cm25 = new CastMember { Id = 25, Name = "Miguel Herrán" };

            var cm26 = new CastMember { Id = 26, Name = "Sofía Vergara" };
            var cm27 = new CastMember { Id = 27, Name = "Eric Stonestreet" };
            var cm28 = new CastMember { Id = 28, Name = "Julie Bowen" };
            var cm29 = new CastMember { Id = 29, Name = "Sarah Hyland" };

            var cm30 = new CastMember { Id = 30, Name = "Pedro Pascal" };
            var cm31 = new CastMember { Id = 31, Name = "Gina Carano" };
            var cm32 = new CastMember { Id = 32, Name = "Giancarlo Esposito" };
            var cm33 = new CastMember { Id = 33, Name = "Carl Weathers" };

            var cm34 = new CastMember { Id = 34, Name = "Daniel Radcliffe" };
            var cm35 = new CastMember { Id = 35, Name = "Emma Watson" };
            var cm36 = new CastMember { Id = 36, Name = "Rupert Grint" };

            var cm37 = new CastMember { Id = 37, Name = "Chloe Bennet" };
            var cm38 = new CastMember { Id = 38, Name = "Elizabeth Henstridge" };
            var cm39 = new CastMember { Id = 39, Name = "Ming‑Na Wen" };

            var cm40 = new CastMember { Id = 40, Name = "Emma Thompson" };
            var cm41 = new CastMember { Id = 41, Name = "Russell Tovey" };
            var cm42 = new CastMember { Id = 42, Name = "Ruth Madeley" };

            var cm43 = new CastMember { Id = 43, Name = "Lucas Till" };
            var cm44 = new CastMember { Id = 44, Name = "Tristin Mays" };
            var cm45 = new CastMember { Id = 45, Name = "Meredith Eaton" };

            var cm46 = new CastMember { Id = 46, Name = "Ellen Pompeo" };
            var cm47 = new CastMember { Id = 47, Name = "Chandra Wilson" };
            var cm48 = new CastMember { Id = 48, Name = "James Pickens Jr." };

            var cm49 = new CastMember { Id = 49, Name = "Zendaya" };
            var cm50 = new CastMember { Id = 50, Name = "Hunter Schafer" };
            var cm51 = new CastMember { Id = 51, Name = "Jacob Elordi" };

            var cm52 = new CastMember { Id = 52, Name = "Henry Cavil" };
            var cm53 = new CastMember { Id = 53, Name = "Anya Chalotra" };
            var cm54 = new CastMember { Id = 54, Name = "Freya Allan" };

            var cm55 = new CastMember { Id = 55, Name = "Kiernan Shipka" };
            var cm56 = new CastMember { Id = 56, Name = "Ross Lynch" };
            var cm57 = new CastMember { Id = 57, Name = "Gavin Leatherwood" };

            var cm58 = new CastMember { Id = 58, Name = "Zoe Saldana" };
            var cm59 = new CastMember { Id = 59, Name = "Sam Worthington" };
            var cm60 = new CastMember { Id = 60, Name = "Sigourney Weaver" };
            #endregion

            #region Movies
            var m1 = new Movie
            {
                Id = 1,
                Title = "Star Wars: A New Hope (Episode IV)",
                Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                ReleaseDate = new DateTime(1997, 5, 25),
                CoverImage = "https://kbimages1-a.akamaihd.net/538b1473-6d45-47f4-b16e-32a0a6ba7f9a/1200/1200/False/star-wars-episode-iv-a-new-hope-3.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m2 = new Movie
            {
                Id = 2,
                Title = "Star Wars: The Empire Strikes Back (Episode V)",
                Description = "Darth Vader is adamant about turning Luke Skywalker to the dark side. Master Yoda trains Luke to become a Jedi Knight while his friends try to fend off the Imperial fleet.",
                ReleaseDate = new DateTime(1980, 5, 21),
                CoverImage = "https://images.penguinrandomhouse.com/cover/9780345320223",
                Rating = 4.8,
                IsMovie = true
            };

            var m3 = new Movie
            {
                Id = 3,
                Title = "Riverdale",
                Description = "Archie, Betty, Jughead and Veronica tackle being teenagers in a town that is rife with sinister happenings and blood-thirsty criminals.",
                ReleaseDate = new DateTime(2017, 1, 26),
                CoverImage = "https://static.wikia.nocookie.net/riverdalearchie/images/3/3a/Season_2_Poster.jpg",
                Rating = 4.5,
                IsMovie = false
            };

            var m4 = new Movie
            {
                Id = 4,
                Title = "The Blacklist",
                Description = "A wanted fugitive mysteriously surrenders himself to the FBI and offers to help them capture deadly criminals. His sole condition is that he will work only with the new profiler, Elizabeth Keen.",
                ReleaseDate = new DateTime(2013, 9, 23),
                CoverImage = "https://static.wikia.nocookie.net/blacklist/images/5/57/Season_7_Poster.jpg",
                Rating = 5,
                IsMovie = false
            };

            var m5 = new Movie
            {
                Id = 5,
                Title = "Star Wars: Return of the Jedi (Episode VI)",
                Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                ReleaseDate = new DateTime(1983, 5, 25),
                CoverImage = "https://m.media-amazon.com/images/I/91LlN7J+Z9L._SL1500_.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m6 = new Movie
            {
                Id = 6,
                Title = "Star Wars: The Force Awakens (Episode VII)",
                Description = "A new order threatens to destroy the New Republic. Finn, Rey and Poe, backed by the Resistance and the Republic, must find a way to stop them and find Luke, the last surviving Jedi.",
                ReleaseDate = new DateTime(2015, 11, 17),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m7 = new Movie
            {
                Id = 7,
                Title = "Star Wars: The Last Jedi (Episode VIII)",
                Description = "Rey seeks to learn the ways of the Jedi under Luke Skywalker, its remaining member, to reinvigorate the Resistance's war against the First Order.",
                ReleaseDate = new DateTime(2017, 11, 15),
                CoverImage = "https://i.pinimg.com/originals/f4/5a/ea/f45aea75f65c0feb5cbe168f17a9a087.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m8 = new Movie
            {
                Id = 8,
                Title = "Star Wars: The Rise of Skywalker (Episode IX)",
                Description = "The revival of Emperor Palpatine resurrects the battle between the Resistance and the First Order while the Jedi's legendary conflict with the Sith Lord comes to a head.",
                ReleaseDate = new DateTime(2019, 11, 20),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/star-wars-the-rise-of-skywalker-theatrical-poster-1000_ebc74357.jpeg?region=0%2C0%2C891%2C1372",
                Rating = 4,
                IsMovie = true
            };

            var m9 = new Movie
            {
                Id = 9,
                Title = "Star Wars: The Phantom Menace (Episode I)",
                Description = "Jedi Knights Qui-Gon Jinn and Obi-Wan Kenobi set out to stop the Trade Federation from invading Naboo. While travelling, they come across a gifted boy, Anakin, and learn that the Sith have returned.",
                ReleaseDate = new DateTime(1999, 4, 19),
                CoverImage = "https://play-lh.googleusercontent.com/sR1pzOxnF50WLR3vUqXYFvY01_tLD4XPn1RDHf0Xh-W04Vek_3iiZ98U7Db2JcmrqS8",
                Rating = 3.5,
                IsMovie = true
            };

            var m10 = new Movie
            {
                Id = 10,
                Title = "Star Wars: Attack of the Clones (Episode II)",
                Description = "While pursuing an assassin, Obi Wan uncovers a sinister plot to destroy the Republic. With the fate of the galaxy hanging in the balance, the Jedi must defend the galaxy against the evil Sith.",
                ReleaseDate = new DateTime(2002, 4, 16),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMDAzM2M0Y2UtZjRmZi00MzVlLTg4MjEtOTE3NzU5ZDVlMTU5XkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_.jpg",
                Rating = 3.8,
                IsMovie = true
            };

            var m11 = new Movie
            {
                Id = 11,
                Title = "Star Wars: Revenge of the Sith (Episode III)",
                Description = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation.",
                ReleaseDate = new DateTime(2005, 4, 19),
                CoverImage = "https://play-lh.googleusercontent.com/mMyoXM8bf72KK-Udap4-hAvqqdXgn0AIBXkS8zejT0RXITIh8oK9a-SYIVk89CA0rHJi",
                Rating = 4.2,
                IsMovie = true
            };

            var m12 = new Movie
            {
                Id = 12,
                Title = "Avatar",
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                ReleaseDate = new DateTime(2009, 11, 17),
                CoverImage = "https://i.pinimg.com/originals/17/aa/71/17aa718c1ab15b482505b8431cf596fc.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m13 = new Movie
            {
                Id = 13,
                Title = "Chernobyl",
                Description = "In April 1986, the city of Chernobyl in the Soviet Union suffers one of the worst nuclear disasters in the history of mankind. Consequently, many heroes put their lives on the line to save Europe.",
                ReleaseDate = new DateTime(2019, 4, 6),
                CoverImage = "https://i.pinimg.com/originals/06/b2/2f/06b22f1ec7b9a6914ec6255f40953e98.jpg",
                Rating = 3.6,
                IsMovie = false
            };

            var m14 = new Movie
            {
                Id = 14,
                Title = "La Casa De Papel",
                Description = "A criminal mastermind who goes by \"The Professor\" has a plan to pull off the biggest heist in recorded history -- to print billions of euros in the Royal Mint of Spain. To help him carry out the ambitious plan, he recruits eight people with certain abilities and who have nothing to lose.",
                ReleaseDate = new DateTime(2017, 4, 2),
                CoverImage = "https://www.enigma-mag.com/wp-content/uploads/2019/08/1563490297.jpg",
                Rating = 4,
                IsMovie = false
            };

            var m15 = new Movie
            {
                Id = 15,
                Title = "Modern Family",
                Description = "Three modern-day families from California try to deal with their kids, quirky spouses and jobs in their own unique ways, often falling into hilarious situations.",
                ReleaseDate = new DateTime(2009, 8, 23),
                CoverImage = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Modern_Family_Season_Two_DVD_Cover.png/250px-Modern_Family_Season_Two_DVD_Cover.png",
                Rating = 4.3,
                IsMovie = false
            };

            var m16 = new Movie
            {
                Id = 16,
                Title = "The Mandalorian",
                Description = "After the defeat of the Empire at the hands of Rebel forces, a lone bounty hunter operating in the Outer Rim, away from the dominion of the New Republic, goes on many surprising and risky adventures.",
                ReleaseDate = new DateTime(2019, 10, 12),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_fyc_themandalorian_19097_de619ea9.jpeg",
                Rating = 4.2,
                IsMovie = false
            };

            var m17 = new Movie
            {
                Id = 17,
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                ReleaseDate = new DateTime(2001, 11, 14),
                CoverImage = "https://movieguise.files.wordpress.com/2016/01/potter.jpg",
                Rating = 4.6,
                IsMovie = true
            };

            var m18 = new Movie
            {
                Id = 18,
                Title = "Harry Potter and The Chamber Of Secrets",
                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                ReleaseDate = new DateTime(2002, 11, 3),
                CoverImage = "https://www.hylandcinema.com/files/hyland/movie-posters/hp-_chamber.jpg",
                Rating = 4.4,
                IsMovie = true
            };

            var m19 = new Movie
            {
                Id = 19,
                Title = "Harry Potter and The Prisoner Of Azkaban",
                Description = "Harry, Ron and Hermoine return to Hogwarts just as they learn about Sirius Black and his plans to kill Harry. However, when Harry runs into him, he learns that the truth is far from reality.",
                ReleaseDate = new DateTime(2004, 5, 31),
                CoverImage = "https://static.wikia.nocookie.net/warner-bros-entertainment/images/c/cb/Harry-potter-and-the-prisoner-of-azkaban-movie-poster-style-f-11x17.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m20 = new Movie
            {
                Id = 20,
                Title = "Agents of S.H.I.E.L.D.",
                Description = "Agent Phil Coulson leads a team of highly skilled agents from the global law-enforcement organisation known as S.H.I.E.L.D. Together, they combat extraordinary and inexplicable threats.",
                ReleaseDate = new DateTime(2013, 9, 24),
                CoverImage = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/1/10/AoS_Season_One_Poster.jpg",
                Rating = 4.9,
                IsMovie = false
            };

            var m21 = new Movie
            {
                Id = 21,
                Title = "Years and Years",
                Description = "An ordinary British family contends with the hopes, anxieties and joys of an uncertain future in this six-part limited series that begins in 2019 and propels the characters 15 years forward into an unstable world.",
                ReleaseDate = new DateTime(2019, 5, 14),
                CoverImage = "https://i.pinimg.com/474x/4e/96/06/4e9606a7f386cafa7903e28e94e43627.jpg",
                Rating = 2.7,
                IsMovie = false
            };

            var m22 = new Movie
            {
                Id = 22,
                Title = "MacGyver",
                Description = "MacGyver, a contemporary hero and role model, applies his scientific knowledge to ordinary items to create a means of escape for himself and others from impending doom.",
                ReleaseDate = new DateTime(2016, 9, 23),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMTg1NzUzNmQtMWI2ZC00YzdlLWI5ZTgtMGM3MjJlZTgwYTVlXkEyXkFqcGdeQXVyMTIzMzY2NDQ2._V1_FMjpg_UX1000_.jpg",
                Rating = 3.3,
                IsMovie = false
            };

            var m23 = new Movie
            {
                Id = 23,
                Title = "Grey's Anatomy",
                Description = "Surgical interns and their supervisors embark on a medical journey where they become part of heart-wrenching stories and make life-changing decisions in order to become the finest doctors.",
                ReleaseDate = new DateTime(2005, 3, 27),
                CoverImage = "http://www.gstatic.com/tv/thumb/tvbanners/17114349/p17114349_b_v12_aa.jpg",
                Rating = 5,
                IsMovie = false
            };

            var m24 = new Movie
            {
                Id = 24,
                Title = "Euphoria",
                Description = "An American adaptation of the Israeli show of the same name, \"Euphoria\" follows the troubled life of 17-year-old Rue, a drug addict fresh from rehab with no plans to stay clean.",
                ReleaseDate = new DateTime(2019, 6, 16),
                CoverImage = "https://lanetechchampion.org/wp-content/uploads/2020/09/zendya-euphoria.jpg",
                Rating = 3,
                IsMovie = false
            };

            var m25 = new Movie
            {
                Id = 25,
                Title = "The Witcher",
                Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                ReleaseDate = new DateTime(2019, 12, 20),
                CoverImage = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg",
                Rating = 5,
                IsMovie = false
            };

            var m26 = new Movie
            {
                Id = 26,
                Title = "Chilling Adventures of Sabrina",
                Description = "This adaptation of the \"Sabrina the Teenage Witch\" tale is a dark coming-of-age story that traffics in horror and the occult. In the reimagined origin story, Sabrina Spellman wrestles to reconcile her dual nature - half-witch, half-mortal.",
                ReleaseDate = new DateTime(2018, 10, 26),
                CoverImage = "https://images-na.ssl-images-amazon.com/images/I/81bLWVTR3sL.jpg",
                Rating = 4.1,
                IsMovie = false
            };

            var m27 = new Movie
            {
                Id = 27,
                Title = "Jurassic Hunt",
                Description = "Female adventurer Parker joins a crew of male trophy hunters in a remote wilderness park. Their goal: slaughter genetically recreated dinosaurs for sport using rifles, arrows, and grenades.",
                ReleaseDate = new DateTime(2021, 8, 23),
                CoverImage = "https://www.themoviedb.org/t/p/w780/Czhr00kB8awffakEcQS5ON1ELm.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m28 = new Movie
            {
                Id = 28,
                Title = "Shang-Chi and the Legend of the Ten Rings",
                Description = "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.",
                ReleaseDate = new DateTime(2021, 9, 1),
                CoverImage = "https://www.themoviedb.org/t/p/w780/pS1XUGjC6ASC1kvDCP3OJnwjk1t.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m29 = new Movie
            {
                Id = 29,
                Title = "Don't Breathe 2",
                Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.",
                ReleaseDate = new DateTime(2021, 8, 12),
                CoverImage = "https://www.themoviedb.org/t/p/w780/hRMfgGFRAZIlvwVWy8DYJdLTpvN.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m30 = new Movie
            {
                Id = 30,
                Title = "Don't Breathe 2",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m31 = new Movie
            {
                Id = 31,
                Title = "The Tomorrow War",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m32 = new Movie
            {
                Id = 32,
                Title = "The Suicide Squad",
                Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/kb4s0ML0iVZlG6wAKbbs9NAm6X.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m33 = new Movie
            {
                Id = 33,
                Title = "SAS: Red Notice",
                Description = "An off-duty SAS soldier, Tom Buckingham, must thwart a terror attack on a train running through the Channel Tunnel. As the action escalates on the train, events transpire in the corridors of power that may make the difference as to whether Buckingham and the civilian passengers make it out of the tunnel alive.",
                ReleaseDate = new DateTime(2021, 8, 11),
                CoverImage = "https://www.themoviedb.org/t/p/w780/6Y9fl8tD1xtyUrOHV2MkCYTpzgi.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m34 = new Movie
            {
                Id = 34,
                Title = "Jungle Cruise",
                Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m35 = new Movie
            {
                Id = 35,
                Title = "Cinderella",
                Description = "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/clDFqATL4zcE7LzUwkrVj3zHvk7.jpg",
                Rating = 3.5,
                IsMovie = true
            };

            var m36 = new Movie
            {
                Id = 36,
                Title = "PAW Patrol: The Movie",
                Description = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos.",
                ReleaseDate = new DateTime(2021, 8, 9),
                CoverImage = "https://www.themoviedb.org/t/p/w780/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                Rating = 3.8,
                IsMovie = true
            };

            var m37 = new Movie
            {
                Id = 37,
                Title = "Movie Title 37",
                Description = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation.",
                ReleaseDate = new DateTime(2005, 4, 19),
                CoverImage = "https://play-lh.googleusercontent.com/mMyoXM8bf72KK-Udap4-hAvqqdXgn0AIBXkS8zejT0RXITIh8oK9a-SYIVk89CA0rHJi",
                Rating = 4.2,
                IsMovie = true
            };

            var m38 = new Movie
            {
                Id = 38,
                Title = "Movie Title 38",
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                ReleaseDate = new DateTime(2009, 11, 17),
                CoverImage = "https://i.pinimg.com/originals/17/aa/71/17aa718c1ab15b482505b8431cf596fc.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m39 = new Movie
            {
                Id = 39,
                Title = "Movie Title 39",
                Description = "In April 1986, the city of Chernobyl in the Soviet Union suffers one of the worst nuclear disasters in the history of mankind. Consequently, many heroes put their lives on the line to save Europe.",
                ReleaseDate = new DateTime(2019, 4, 6),
                CoverImage = "https://i.pinimg.com/originals/06/b2/2f/06b22f1ec7b9a6914ec6255f40953e98.jpg",
                Rating = 3.6,
                IsMovie = true
            };

            var m40 = new Movie
            {
                Id = 40,
                Title = "Movie Title 40",
                Description = "A criminal mastermind who goes by \"The Professor\" has a plan to pull off the biggest heist in recorded history -- to print billions of euros in the Royal Mint of Spain. To help him carry out the ambitious plan, he recruits eight people with certain abilities and who have nothing to lose.",
                ReleaseDate = new DateTime(2017, 4, 2),
                CoverImage = "https://www.enigma-mag.com/wp-content/uploads/2019/08/1563490297.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m41 = new Movie
            {
                Id = 41,
                Title = "Movie Title 41",
                Description = "Three modern-day families from California try to deal with their kids, quirky spouses and jobs in their own unique ways, often falling into hilarious situations.",
                ReleaseDate = new DateTime(2009, 8, 23),
                CoverImage = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Modern_Family_Season_Two_DVD_Cover.png/250px-Modern_Family_Season_Two_DVD_Cover.png",
                Rating = 4.3,
                IsMovie = true
            };

            var m42 = new Movie
            {
                Id = 42,
                Title = "Movie Title 42",
                Description = "After the defeat of the Empire at the hands of Rebel forces, a lone bounty hunter operating in the Outer Rim, away from the dominion of the New Republic, goes on many surprising and risky adventures.",
                ReleaseDate = new DateTime(2019, 10, 12),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_fyc_themandalorian_19097_de619ea9.jpeg",
                Rating = 4.2,
                IsMovie = true
            };

            var m43 = new Movie
            {
                Id = 43,
                Title = "Movie Title 43",
                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                ReleaseDate = new DateTime(2001, 11, 14),
                CoverImage = "https://movieguise.files.wordpress.com/2016/01/potter.jpg",
                Rating = 4.6,
                IsMovie = true
            };

            var m44 = new Movie
            {
                Id = 44,
                Title = "Movie Title 44",
                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                ReleaseDate = new DateTime(2002, 11, 3),
                CoverImage = "https://www.hylandcinema.com/files/hyland/movie-posters/hp-_chamber.jpg",
                Rating = 4.4,
                IsMovie = true
            };

            var m45 = new Movie
            {
                Id = 45,
                Title = "Movie Title 45",
                Description = "Harry, Ron and Hermoine return to Hogwarts just as they learn about Sirius Black and his plans to kill Harry. However, when Harry runs into him, he learns that the truth is far from reality.",
                ReleaseDate = new DateTime(2004, 5, 31),
                CoverImage = "https://static.wikia.nocookie.net/warner-bros-entertainment/images/c/cb/Harry-potter-and-the-prisoner-of-azkaban-movie-poster-style-f-11x17.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m46 = new Movie
            {
                Id = 46,
                Title = "Movie Title 46",
                Description = "Agent Phil Coulson leads a team of highly skilled agents from the global law-enforcement organisation known as S.H.I.E.L.D. Together, they combat extraordinary and inexplicable threats.",
                ReleaseDate = new DateTime(2013, 9, 24),
                CoverImage = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/1/10/AoS_Season_One_Poster.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m47 = new Movie
            {
                Id = 47,
                Title = "Movie Title 47",
                Description = "An ordinary British family contends with the hopes, anxieties and joys of an uncertain future in this six-part limited series that begins in 2019 and propels the characters 15 years forward into an unstable world.",
                ReleaseDate = new DateTime(2019, 5, 14),
                CoverImage = "https://i.pinimg.com/474x/4e/96/06/4e9606a7f386cafa7903e28e94e43627.jpg",
                Rating = 2.7,
                IsMovie = true
            };

            var m48 = new Movie
            {
                Id = 48,
                Title = "Movie Title 48",
                Description = "MacGyver, a contemporary hero and role model, applies his scientific knowledge to ordinary items to create a means of escape for himself and others from impending doom.",
                ReleaseDate = new DateTime(2016, 9, 23),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMTg1NzUzNmQtMWI2ZC00YzdlLWI5ZTgtMGM3MjJlZTgwYTVlXkEyXkFqcGdeQXVyMTIzMzY2NDQ2._V1_FMjpg_UX1000_.jpg",
                Rating = 3.3,
                IsMovie = true
            };

            var m49 = new Movie
            {
                Id = 49,
                Title = "Movie Title 49",
                Description = "Surgical interns and their supervisors embark on a medical journey where they become part of heart-wrenching stories and make life-changing decisions in order to become the finest doctors.",
                ReleaseDate = new DateTime(2005, 3, 27),
                CoverImage = "http://www.gstatic.com/tv/thumb/tvbanners/17114349/p17114349_b_v12_aa.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m50 = new Movie
            {
                Id = 50,
                Title = "Movie Title 50",
                Description = "An American adaptation of the Israeli show of the same name, \"Euphoria\" follows the troubled life of 17-year-old Rue, a drug addict fresh from rehab with no plans to stay clean.",
                ReleaseDate = new DateTime(2019, 6, 16),
                CoverImage = "https://lanetechchampion.org/wp-content/uploads/2020/09/zendya-euphoria.jpg",
                Rating = 3,
                IsMovie = true
            };

            var m51 = new Movie
            {
                Id = 51,
                Title = "Movie Title 51",
                Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                ReleaseDate = new DateTime(2019, 12, 20),
                CoverImage = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m52 = new Movie
            {
                Id = 52,
                Title = "Movie Title 52",
                Description = "This adaptation of the \"Sabrina the Teenage Witch\" tale is a dark coming-of-age story that traffics in horror and the occult. In the reimagined origin story, Sabrina Spellman wrestles to reconcile her dual nature - half-witch, half-mortal.",
                ReleaseDate = new DateTime(2018, 10, 26),
                CoverImage = "https://images-na.ssl-images-amazon.com/images/I/81bLWVTR3sL.jpg",
                Rating = 4.1,
                IsMovie = true
            };

            var m53 = new Movie
            {
                Id = 53,
                Title = "Movie Title 53",
                Description = "Female adventurer Parker joins a crew of male trophy hunters in a remote wilderness park. Their goal: slaughter genetically recreated dinosaurs for sport using rifles, arrows, and grenades.",
                ReleaseDate = new DateTime(2021, 8, 23),
                CoverImage = "https://www.themoviedb.org/t/p/w780/Czhr00kB8awffakEcQS5ON1ELm.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m54 = new Movie
            {
                Id = 54,
                Title = "Movie Title 54",
                Description = "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.",
                ReleaseDate = new DateTime(2021, 9, 1),
                CoverImage = "https://www.themoviedb.org/t/p/w780/pS1XUGjC6ASC1kvDCP3OJnwjk1t.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m55 = new Movie
            {
                Id = 55,
                Title = "Movie Title 55",
                Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.",
                ReleaseDate = new DateTime(2021, 8, 12),
                CoverImage = "https://www.themoviedb.org/t/p/w780/hRMfgGFRAZIlvwVWy8DYJdLTpvN.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m56 = new Movie
            {
                Id = 56,
                Title = "Movie Title 56",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m57 = new Movie
            {
                Id = 57,
                Title = "Movie Title 57",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m58 = new Movie
            {
                Id = 58,
                Title = "Movie Title 58",
                Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/kb4s0ML0iVZlG6wAKbbs9NAm6X.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m59 = new Movie
            {
                Id = 59,
                Title = "Movie Title 59",
                Description = "An off-duty SAS soldier, Tom Buckingham, must thwart a terror attack on a train running through the Channel Tunnel. As the action escalates on the train, events transpire in the corridors of power that may make the difference as to whether Buckingham and the civilian passengers make it out of the tunnel alive.",
                ReleaseDate = new DateTime(2021, 8, 11),
                CoverImage = "https://www.themoviedb.org/t/p/w780/6Y9fl8tD1xtyUrOHV2MkCYTpzgi.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m60 = new Movie
            {
                Id = 60,
                Title = "Movie Title 60",
                Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m61 = new Movie
            {
                Id = 61,
                Title = "Movie Title 61",
                Description = "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/clDFqATL4zcE7LzUwkrVj3zHvk7.jpg",
                Rating = 3.5,
                IsMovie = true
            };

            var m62 = new Movie
            {
                Id = 62,
                Title = "Movie Title 62",
                Description = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos.",
                ReleaseDate = new DateTime(2021, 8, 9),
                CoverImage = "https://www.themoviedb.org/t/p/w780/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                Rating = 3.8,
                IsMovie = true
            };

            var m63 = new Movie
            {
                Id = 63,
                Title = "Movie Title 63",
                Description = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation.",
                ReleaseDate = new DateTime(2005, 4, 19),
                CoverImage = "https://play-lh.googleusercontent.com/mMyoXM8bf72KK-Udap4-hAvqqdXgn0AIBXkS8zejT0RXITIh8oK9a-SYIVk89CA0rHJi",
                Rating = 4.2,
                IsMovie = true
            };

            var m64 = new Movie
            {
                Id = 64,
                Title = "Movie Title 64",
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                ReleaseDate = new DateTime(2009, 11, 17),
                CoverImage = "https://i.pinimg.com/originals/17/aa/71/17aa718c1ab15b482505b8431cf596fc.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m65 = new Movie
            {
                Id = 65,
                Title = "Movie Title 65",
                Description = "In April 1986, the city of Chernobyl in the Soviet Union suffers one of the worst nuclear disasters in the history of mankind. Consequently, many heroes put their lives on the line to save Europe.",
                ReleaseDate = new DateTime(2019, 4, 6),
                CoverImage = "https://i.pinimg.com/originals/06/b2/2f/06b22f1ec7b9a6914ec6255f40953e98.jpg",
                Rating = 3.6,
                IsMovie = true
            };

            var m66 = new Movie
            {
                Id = 66,
                Title = "Movie Title 66",
                Description = "A criminal mastermind who goes by \"The Professor\" has a plan to pull off the biggest heist in recorded history -- to print billions of euros in the Royal Mint of Spain. To help him carry out the ambitious plan, he recruits eight people with certain abilities and who have nothing to lose.",
                ReleaseDate = new DateTime(2017, 4, 2),
                CoverImage = "https://www.enigma-mag.com/wp-content/uploads/2019/08/1563490297.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m67 = new Movie
            {
                Id = 67,
                Title = "Movie Title 67",
                Description = "Three modern-day families from California try to deal with their kids, quirky spouses and jobs in their own unique ways, often falling into hilarious situations.",
                ReleaseDate = new DateTime(2009, 8, 23),
                CoverImage = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Modern_Family_Season_Two_DVD_Cover.png/250px-Modern_Family_Season_Two_DVD_Cover.png",
                Rating = 4.3,
                IsMovie = true
            };

            var m68 = new Movie
            {
                Id = 68,
                Title = "Movie Title 68",
                Description = "After the defeat of the Empire at the hands of Rebel forces, a lone bounty hunter operating in the Outer Rim, away from the dominion of the New Republic, goes on many surprising and risky adventures.",
                ReleaseDate = new DateTime(2019, 10, 12),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_fyc_themandalorian_19097_de619ea9.jpeg",
                Rating = 4.2,
                IsMovie = true
            };

            var m69 = new Movie
            {
                Id = 69,
                Title = "Movie Title 69",
                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                ReleaseDate = new DateTime(2001, 11, 14),
                CoverImage = "https://movieguise.files.wordpress.com/2016/01/potter.jpg",
                Rating = 4.6,
                IsMovie = true
            };

            var m70 = new Movie
            {
                Id = 70,
                Title = "Movie Title 70",
                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                ReleaseDate = new DateTime(2002, 11, 3),
                CoverImage = "https://www.hylandcinema.com/files/hyland/movie-posters/hp-_chamber.jpg",
                Rating = 4.4,
                IsMovie = true
            };

            var m71 = new Movie
            {
                Id = 71,
                Title = "Movie Title 71",
                Description = "Harry, Ron and Hermoine return to Hogwarts just as they learn about Sirius Black and his plans to kill Harry. However, when Harry runs into him, he learns that the truth is far from reality.",
                ReleaseDate = new DateTime(2004, 5, 31),
                CoverImage = "https://static.wikia.nocookie.net/warner-bros-entertainment/images/c/cb/Harry-potter-and-the-prisoner-of-azkaban-movie-poster-style-f-11x17.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m72 = new Movie
            {
                Id = 72,
                Title = "Movie Title 72",
                Description = "Agent Phil Coulson leads a team of highly skilled agents from the global law-enforcement organisation known as S.H.I.E.L.D. Together, they combat extraordinary and inexplicable threats.",
                ReleaseDate = new DateTime(2013, 9, 24),
                CoverImage = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/1/10/AoS_Season_One_Poster.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m73 = new Movie
            {
                Id = 73,
                Title = "Movie Title 73",
                Description = "An ordinary British family contends with the hopes, anxieties and joys of an uncertain future in this six-part limited series that begins in 2019 and propels the characters 15 years forward into an unstable world.",
                ReleaseDate = new DateTime(2019, 5, 14),
                CoverImage = "https://i.pinimg.com/474x/4e/96/06/4e9606a7f386cafa7903e28e94e43627.jpg",
                Rating = 2.7,
                IsMovie = true
            };

            var m74 = new Movie
            {
                Id = 74,
                Title = "Movie Title 74",
                Description = "MacGyver, a contemporary hero and role model, applies his scientific knowledge to ordinary items to create a means of escape for himself and others from impending doom.",
                ReleaseDate = new DateTime(2016, 9, 23),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMTg1NzUzNmQtMWI2ZC00YzdlLWI5ZTgtMGM3MjJlZTgwYTVlXkEyXkFqcGdeQXVyMTIzMzY2NDQ2._V1_FMjpg_UX1000_.jpg",
                Rating = 3.3,
                IsMovie = true
            };

            var m75 = new Movie
            {
                Id = 75,
                Title = "Movie Title 75",
                Description = "Surgical interns and their supervisors embark on a medical journey where they become part of heart-wrenching stories and make life-changing decisions in order to become the finest doctors.",
                ReleaseDate = new DateTime(2005, 3, 27),
                CoverImage = "http://www.gstatic.com/tv/thumb/tvbanners/17114349/p17114349_b_v12_aa.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m76 = new Movie
            {
                Id = 76,
                Title = "Movie Title 76",
                Description = "An American adaptation of the Israeli show of the same name, \"Euphoria\" follows the troubled life of 17-year-old Rue, a drug addict fresh from rehab with no plans to stay clean.",
                ReleaseDate = new DateTime(2019, 6, 16),
                CoverImage = "https://lanetechchampion.org/wp-content/uploads/2020/09/zendya-euphoria.jpg",
                Rating = 3,
                IsMovie = true
            };

            var m77 = new Movie
            {
                Id = 77,
                Title = "Movie Title 77",
                Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                ReleaseDate = new DateTime(2019, 12, 20),
                CoverImage = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m78 = new Movie
            {
                Id = 78,
                Title = "Movie Title 78",
                Description = "This adaptation of the \"Sabrina the Teenage Witch\" tale is a dark coming-of-age story that traffics in horror and the occult. In the reimagined origin story, Sabrina Spellman wrestles to reconcile her dual nature - half-witch, half-mortal.",
                ReleaseDate = new DateTime(2018, 10, 26),
                CoverImage = "https://images-na.ssl-images-amazon.com/images/I/81bLWVTR3sL.jpg",
                Rating = 4.1,
                IsMovie = true
            };

            var m79 = new Movie
            {
                Id = 79,
                Title = "Movie Title 79",
                Description = "Female adventurer Parker joins a crew of male trophy hunters in a remote wilderness park. Their goal: slaughter genetically recreated dinosaurs for sport using rifles, arrows, and grenades.",
                ReleaseDate = new DateTime(2021, 8, 23),
                CoverImage = "https://www.themoviedb.org/t/p/w780/Czhr00kB8awffakEcQS5ON1ELm.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m80 = new Movie
            {
                Id = 80,
                Title = "Movie Title 80",
                Description = "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.",
                ReleaseDate = new DateTime(2021, 9, 1),
                CoverImage = "https://www.themoviedb.org/t/p/w780/pS1XUGjC6ASC1kvDCP3OJnwjk1t.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m81 = new Movie
            {
                Id = 81,
                Title = "Movie Title 81",
                Description = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals kidnap the girl.",
                ReleaseDate = new DateTime(2021, 8, 12),
                CoverImage = "https://www.themoviedb.org/t/p/w780/hRMfgGFRAZIlvwVWy8DYJdLTpvN.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m82 = new Movie
            {
                Id = 82,
                Title = "Movie Title 82",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m83 = new Movie
            {
                Id = 83,
                Title = "Movie Title 83",
                Description = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m84 = new Movie
            {
                Id = 84,
                Title = "Movie Title 84",
                Description = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/kb4s0ML0iVZlG6wAKbbs9NAm6X.jpg",
                Rating = 4.5,
                IsMovie = true
            };

            var m85 = new Movie
            {
                Id = 85,
                Title = "Movie Title 85",
                Description = "An off-duty SAS soldier, Tom Buckingham, must thwart a terror attack on a train running through the Channel Tunnel. As the action escalates on the train, events transpire in the corridors of power that may make the difference as to whether Buckingham and the civilian passengers make it out of the tunnel alive.",
                ReleaseDate = new DateTime(2021, 8, 11),
                CoverImage = "https://www.themoviedb.org/t/p/w780/6Y9fl8tD1xtyUrOHV2MkCYTpzgi.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m86 = new Movie
            {
                Id = 86,
                Title = "Movie Title 86",
                Description = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery that will change the future of medicine.",
                ReleaseDate = new DateTime(2021, 7, 28),
                CoverImage = "https://www.themoviedb.org/t/p/w780/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m87 = new Movie
            {
                Id = 87,
                Title = "Movie Title 87",
                Description = "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous Godmother, she perseveres to make them come true.",
                ReleaseDate = new DateTime(2021, 9, 3),
                CoverImage = "https://www.themoviedb.org/t/p/w780/clDFqATL4zcE7LzUwkrVj3zHvk7.jpg",
                Rating = 3.5,
                IsMovie = true
            };

            var m88 = new Movie
            {
                Id = 88,
                Title = "Movie Title 88",
                Description = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling metropolis into a state of chaos.",
                ReleaseDate = new DateTime(2021, 8, 9),
                CoverImage = "https://www.themoviedb.org/t/p/w780/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                Rating = 3.8,
                IsMovie = true
            };

            var m89 = new Movie
            {
                Id = 89,
                Title = "Movie Title 89",
                Description = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation.",
                ReleaseDate = new DateTime(2005, 4, 19),
                CoverImage = "https://play-lh.googleusercontent.com/mMyoXM8bf72KK-Udap4-hAvqqdXgn0AIBXkS8zejT0RXITIh8oK9a-SYIVk89CA0rHJi",
                Rating = 4.2,
                IsMovie = true
            };

            var m90 = new Movie
            {
                Id = 90,
                Title = "Movie Title 90",
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                ReleaseDate = new DateTime(2009, 11, 17),
                CoverImage = "https://i.pinimg.com/originals/17/aa/71/17aa718c1ab15b482505b8431cf596fc.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m91 = new Movie
            {
                Id = 91,
                Title = "Movie Title 91",
                Description = "In April 1986, the city of Chernobyl in the Soviet Union suffers one of the worst nuclear disasters in the history of mankind. Consequently, many heroes put their lives on the line to save Europe.",
                ReleaseDate = new DateTime(2019, 4, 6),
                CoverImage = "https://i.pinimg.com/originals/06/b2/2f/06b22f1ec7b9a6914ec6255f40953e98.jpg",
                Rating = 3.6,
                IsMovie = true
            };

            var m92 = new Movie
            {
                Id = 92,
                Title = "Movie Title 92",
                Description = "A criminal mastermind who goes by \"The Professor\" has a plan to pull off the biggest heist in recorded history -- to print billions of euros in the Royal Mint of Spain. To help him carry out the ambitious plan, he recruits eight people with certain abilities and who have nothing to lose.",
                ReleaseDate = new DateTime(2017, 4, 2),
                CoverImage = "https://www.enigma-mag.com/wp-content/uploads/2019/08/1563490297.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m93 = new Movie
            {
                Id = 93,
                Title = "Movie Title 93",
                Description = "Three modern-day families from California try to deal with their kids, quirky spouses and jobs in their own unique ways, often falling into hilarious situations.",
                ReleaseDate = new DateTime(2009, 8, 23),
                CoverImage = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Modern_Family_Season_Two_DVD_Cover.png/250px-Modern_Family_Season_Two_DVD_Cover.png",
                Rating = 4.3,
                IsMovie = true
            };

            var m94 = new Movie
            {
                Id = 94,
                Title = "Movie Title 94",
                Description = "After the defeat of the Empire at the hands of Rebel forces, a lone bounty hunter operating in the Outer Rim, away from the dominion of the New Republic, goes on many surprising and risky adventures.",
                ReleaseDate = new DateTime(2019, 10, 12),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_fyc_themandalorian_19097_de619ea9.jpeg",
                Rating = 4.2,
                IsMovie = true
            };

            var m95 = new Movie
            {
                Id = 95,
                Title = "Movie Title 95",
                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                ReleaseDate = new DateTime(2001, 11, 14),
                CoverImage = "https://movieguise.files.wordpress.com/2016/01/potter.jpg",
                Rating = 4.6,
                IsMovie = true
            };

            var m96 = new Movie
            {
                Id = 96,
                Title = "Movie Title 96",
                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                ReleaseDate = new DateTime(2002, 11, 3),
                CoverImage = "https://www.hylandcinema.com/files/hyland/movie-posters/hp-_chamber.jpg",
                Rating = 4.4,
                IsMovie = true
            };

            var m97 = new Movie
            {
                Id = 97,
                Title = "Movie Title 97",
                Description = "Harry, Ron and Hermoine return to Hogwarts just as they learn about Sirius Black and his plans to kill Harry. However, when Harry runs into him, he learns that the truth is far from reality.",
                ReleaseDate = new DateTime(2004, 5, 31),
                CoverImage = "https://static.wikia.nocookie.net/warner-bros-entertainment/images/c/cb/Harry-potter-and-the-prisoner-of-azkaban-movie-poster-style-f-11x17.jpg",
                Rating = 4,
                IsMovie = true
            };

            var m98 = new Movie
            {
                Id = 98,
                Title = "Movie Title 98",
                Description = "Agent Phil Coulson leads a team of highly skilled agents from the global law-enforcement organisation known as S.H.I.E.L.D. Together, they combat extraordinary and inexplicable threats.",
                ReleaseDate = new DateTime(2013, 9, 24),
                CoverImage = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/1/10/AoS_Season_One_Poster.jpg",
                Rating = 4.9,
                IsMovie = true
            };

            var m99 = new Movie
            {
                Id = 99,
                Title = "Movie Title 99",
                Description = "An ordinary British family contends with the hopes, anxieties and joys of an uncertain future in this six-part limited series that begins in 2019 and propels the characters 15 years forward into an unstable world.",
                ReleaseDate = new DateTime(2019, 5, 14),
                CoverImage = "https://i.pinimg.com/474x/4e/96/06/4e9606a7f386cafa7903e28e94e43627.jpg",
                Rating = 2.7,
                IsMovie = true
            };

            var m100 = new Movie
            {
                Id = 100,
                Title = "Movie Title 100",
                Description = "MacGyver, a contemporary hero and role model, applies his scientific knowledge to ordinary items to create a means of escape for himself and others from impending doom.",
                ReleaseDate = new DateTime(2016, 9, 23),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMTg1NzUzNmQtMWI2ZC00YzdlLWI5ZTgtMGM3MjJlZTgwYTVlXkEyXkFqcGdeQXVyMTIzMzY2NDQ2._V1_FMjpg_UX1000_.jpg",
                Rating = 3.3,
                IsMovie = true
            };

            var m101 = new Movie
            {
                Id = 101,
                Title = "Movie Title 101",
                Description = "Surgical interns and their supervisors embark on a medical journey where they become part of heart-wrenching stories and make life-changing decisions in order to become the finest doctors.",
                ReleaseDate = new DateTime(2005, 3, 27),
                CoverImage = "http://www.gstatic.com/tv/thumb/tvbanners/17114349/p17114349_b_v12_aa.jpg",
                Rating = 5,
                IsMovie = true
            };

            var m102 = new Movie
            {
                Id = 102,
                Title = "Movie Title 102",
                Description = "Surgical interns and their supervisors embark on a medical journey where they become part of heart-wrenching stories and make life-changing decisions in order to become the finest doctors.",
                ReleaseDate = new DateTime(2005, 3, 27),
                CoverImage = "http://www.gstatic.com/tv/thumb/tvbanners/17114349/p17114349_b_v12_aa.jpg",
                IsMovie = true
            };

            var m103 = new Movie
            {
                Id = 103,
                Title = "Movie Title 103",
                Description = "MacGyver, a contemporary hero and role model, applies his scientific knowledge to ordinary items to create a means of escape for himself and others from impending doom.",
                ReleaseDate = new DateTime(2016, 9, 23),
                CoverImage = "https://m.media-amazon.com/images/M/MV5BMTg1NzUzNmQtMWI2ZC00YzdlLWI5ZTgtMGM3MjJlZTgwYTVlXkEyXkFqcGdeQXVyMTIzMzY2NDQ2._V1_FMjpg_UX1000_.jpg",
                IsMovie = true
            };

            var m104 = new Movie
            {
                Id = 104,
                Title = "Movie Title 104",
                Description = "Agent Phil Coulson leads a team of highly skilled agents from the global law-enforcement organisation known as S.H.I.E.L.D. Together, they combat extraordinary and inexplicable threats.",
                ReleaseDate = new DateTime(2013, 9, 24),
                CoverImage = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/1/10/AoS_Season_One_Poster.jpg",
                IsMovie = true
            };

            var m105 = new Movie
            {
                Id = 105,
                Title = "Movie Title 105",
                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                ReleaseDate = new DateTime(2002, 11, 3),
                CoverImage = "https://www.hylandcinema.com/files/hyland/movie-posters/hp-_chamber.jpg",
                Rating = 4.4,
                IsMovie = true
            };


            var m106 = new Movie
            {
                Id = 106,
                Title = "Movie Title 106",
                Description = "After the defeat of the Empire at the hands of Rebel forces, a lone bounty hunter operating in the Outer Rim, away from the dominion of the New Republic, goes on many surprising and risky adventures.",
                ReleaseDate = new DateTime(2019, 10, 12),
                CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_fyc_themandalorian_19097_de619ea9.jpeg",
                IsMovie = true
            };

            var m107 = new Movie
            {
                Id = 107,
                Title = "Movie Title 107",
                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                ReleaseDate = new DateTime(2001, 11, 14),
                CoverImage = "https://movieguise.files.wordpress.com/2016/01/potter.jpg",
                IsMovie = true
            };
            #endregion

            #region Ratings
            var r1 = new Rating { Id = 1, Value = 5, RatedMovieId = m1.Id };
            var r2 = new Rating { Id = 2, Value = 4.8, RatedMovieId = m2.Id };
            var r3 = new Rating { Id = 3, Value = 4.5, RatedMovieId = m3.Id };
            var r4 = new Rating { Id = 4, Value = 5, RatedMovieId = m4.Id };
            var r5 = new Rating { Id = 5, Value = 4.9, RatedMovieId = m5.Id };
            var r6 = new Rating { Id = 6, Value = 4.5, RatedMovieId = m6.Id };
            var r7 = new Rating { Id = 7, Value = 4.9, RatedMovieId = m7.Id };
            var r8 = new Rating { Id = 8, Value = 4, RatedMovieId = m8.Id };
            var r9 = new Rating { Id = 9, Value = 3.5, RatedMovieId = m9.Id };
            var r10 = new Rating { Id = 10, Value = 3.8, RatedMovieId = m10.Id };
            var r11 = new Rating { Id = 11, Value = 4.2, RatedMovieId = m11.Id };
            var r12 = new Rating { Id = 12, Value = 4.9, RatedMovieId = m12.Id };
            var r13 = new Rating { Id = 13, Value = 3.6, RatedMovieId = m13.Id };
            var r14 = new Rating { Id = 14, Value = 4, RatedMovieId = m14.Id };
            var r15 = new Rating { Id = 15, Value = 4.3, RatedMovieId = m15.Id };
            var r16 = new Rating { Id = 16, Value = 4.2, RatedMovieId = m16.Id };
            var r17 = new Rating { Id = 17, Value = 4.6, RatedMovieId = m17.Id };
            var r18 = new Rating { Id = 18, Value = 4.4, RatedMovieId = m18.Id };
            var r19 = new Rating { Id = 19, Value = 4, RatedMovieId = m19.Id };
            var r20 = new Rating { Id = 20, Value = 4.9, RatedMovieId = m20.Id };
            var r21 = new Rating { Id = 21, Value = 2.7, RatedMovieId = m21.Id };
            var r22 = new Rating { Id = 22, Value = 3.3, RatedMovieId = m22.Id };
            var r23 = new Rating { Id = 23, Value = 5, RatedMovieId = m23.Id };
            var r24 = new Rating { Id = 24, Value = 3, RatedMovieId = m24.Id };
            var r25 = new Rating { Id = 25, Value = 5, RatedMovieId = m25.Id };
            var r26 = new Rating { Id = 26, Value = 4.1, RatedMovieId = m26.Id };

            var r27 = new Rating { Id = 27, Value = 5, RatedMovieId = m27.Id };
            var r28= new Rating { Id = 28, Value = 4.8, RatedMovieId = m28.Id };
            var r29 = new Rating { Id = 29, Value = 4.5, RatedMovieId = m29.Id };
            var r30 = new Rating { Id = 30, Value = 5, RatedMovieId = m30.Id };
            var r31 = new Rating { Id = 31, Value = 4.9, RatedMovieId = m31.Id };
            var r32 = new Rating { Id = 32, Value = 4.5, RatedMovieId = m32.Id };
            var r33 = new Rating { Id = 33, Value = 4.9, RatedMovieId = m33.Id };
            var r34 = new Rating { Id = 34, Value = 4, RatedMovieId = m34.Id };
            var r35 = new Rating { Id = 35, Value = 3.5, RatedMovieId = m35.Id };
            var r36 = new Rating { Id = 36, Value = 3.8, RatedMovieId = m36.Id };
            var r37 = new Rating { Id = 37, Value = 4.2, RatedMovieId = m37.Id };
            var r38 = new Rating { Id = 38, Value = 4.9, RatedMovieId = m38.Id };
            var r39 = new Rating { Id = 39, Value = 3.6, RatedMovieId = m39.Id };
            var r40 = new Rating { Id = 40, Value = 4, RatedMovieId = m40.Id };
            var r41 = new Rating { Id = 41, Value = 4.3, RatedMovieId = m41.Id };
            var r42 = new Rating { Id = 42, Value = 4.2, RatedMovieId = m42.Id };
            var r43 = new Rating { Id = 43, Value = 4.6, RatedMovieId = m43.Id };
            var r44 = new Rating { Id = 44, Value = 4.4, RatedMovieId = m44.Id };
            var r45 = new Rating { Id = 45, Value = 4, RatedMovieId = m45.Id };
            var r46 = new Rating { Id = 46, Value = 4.9, RatedMovieId = m46.Id };
            var r47 = new Rating { Id = 47, Value = 2.7, RatedMovieId = m47.Id };
            var r48 = new Rating { Id = 48, Value = 3.3, RatedMovieId = m48.Id };
            var r49 = new Rating { Id = 49, Value = 5, RatedMovieId = m49.Id };
            var r50 = new Rating { Id = 50, Value = 3, RatedMovieId = m50.Id };
            var r51 = new Rating { Id = 51, Value = 5, RatedMovieId = m51.Id };

            var r52 = new Rating { Id = 52, Value = 5, RatedMovieId = m52.Id };
            var r53 = new Rating { Id = 53, Value = 4.8, RatedMovieId = m53.Id };
            var r54 = new Rating { Id = 54, Value = 4.5, RatedMovieId = m54.Id };
            var r55 = new Rating { Id = 55, Value = 5, RatedMovieId = m55.Id };
            var r56 = new Rating { Id = 56, Value = 4.9, RatedMovieId = m56.Id };
            var r57 = new Rating { Id = 57, Value = 4.5, RatedMovieId = m57.Id };
            var r58 = new Rating { Id = 58, Value = 4.9, RatedMovieId = m58.Id };
            var r59 = new Rating { Id = 59, Value = 4, RatedMovieId = m59.Id };
            var r60 = new Rating { Id = 60, Value = 3.5, RatedMovieId = m60.Id };
            var r61 = new Rating { Id = 61, Value = 3.8, RatedMovieId = m61.Id };
            var r62 = new Rating { Id = 62, Value = 4.2, RatedMovieId = m62.Id };
            var r63 = new Rating { Id = 63, Value = 4.9, RatedMovieId = m63.Id };
            var r64 = new Rating { Id = 64, Value = 3.6, RatedMovieId = m64.Id };
            var r65 = new Rating { Id = 65, Value = 4, RatedMovieId = m65.Id };
            var r66 = new Rating { Id = 66, Value = 4.3, RatedMovieId = m66.Id };
            var r67 = new Rating { Id = 67, Value = 4.2, RatedMovieId = m67.Id };
            var r68 = new Rating { Id = 68, Value = 4.6, RatedMovieId = m68.Id };
            var r69 = new Rating { Id = 69, Value = 4.4, RatedMovieId = m69.Id };
            var r70 = new Rating { Id = 70, Value = 4, RatedMovieId = m70.Id };
            var r71 = new Rating { Id = 71, Value = 4.9, RatedMovieId = m71.Id };
            var r72 = new Rating { Id = 72, Value = 2.7, RatedMovieId = m72.Id };
            var r73 = new Rating { Id = 73, Value = 3.3, RatedMovieId = m73.Id };
            var r74 = new Rating { Id = 74, Value = 5, RatedMovieId = m74.Id };
            var r75 = new Rating { Id = 75, Value = 3, RatedMovieId = m75.Id };
            var r76 = new Rating { Id = 76, Value = 5, RatedMovieId = m76.Id };

            var r77 = new Rating { Id = 77, Value = 5, RatedMovieId = m77.Id };
            var r78 = new Rating { Id = 78, Value = 4.8, RatedMovieId = m78.Id };
            var r79 = new Rating { Id = 79, Value = 4.5, RatedMovieId = m79.Id };
            var r80 = new Rating { Id = 80, Value = 5, RatedMovieId = m80.Id };
            var r81 = new Rating { Id = 81, Value = 4.9, RatedMovieId = m81.Id };
            var r82 = new Rating { Id = 82, Value = 4.5, RatedMovieId = m82.Id };
            var r83 = new Rating { Id = 83, Value = 4.9, RatedMovieId = m83.Id };
            var r84 = new Rating { Id = 84, Value = 4, RatedMovieId = m84.Id };
            var r85 = new Rating { Id = 85, Value = 3.5, RatedMovieId = m85.Id };
            var r86 = new Rating { Id = 86, Value = 3.8, RatedMovieId = m86.Id };
            var r87 = new Rating { Id = 87, Value = 4.2, RatedMovieId = m87.Id };
            var r88 = new Rating { Id = 88, Value = 4.9, RatedMovieId = m88.Id };
            var r89 = new Rating { Id = 89, Value = 3.6, RatedMovieId = m89.Id };
            var r90 = new Rating { Id = 90, Value = 4, RatedMovieId = m90.Id };
            var r91 = new Rating { Id = 91, Value = 4.3, RatedMovieId = m91.Id };
            var r92 = new Rating { Id = 92, Value = 4.2, RatedMovieId = m92.Id };
            var r93 = new Rating { Id = 93, Value = 4.6, RatedMovieId = m93.Id };
            var r94 = new Rating { Id = 94, Value = 4.4, RatedMovieId = m94.Id };
            var r95 = new Rating { Id = 95, Value = 4, RatedMovieId = m95.Id };
            var r96 = new Rating { Id = 96, Value = 4.9, RatedMovieId = m96.Id };
            var r97 = new Rating { Id = 97, Value = 2.7, RatedMovieId = m97.Id };
            var r98 = new Rating { Id = 98, Value = 3.3, RatedMovieId = m98.Id };
            var r99 = new Rating { Id = 99, Value = 5, RatedMovieId = m99.Id };
            var r100 = new Rating { Id = 100, Value = 3, RatedMovieId = m100.Id };
            var r101 = new Rating { Id = 101, Value = 5, RatedMovieId = m101.Id };
            #endregion

            #region Screenings
            var s1 = new Screening
            {
                Id = 1,
                Name = "Screening 1",
                StartTime = DateTime.Now.AddDays(10).AddHours(2),
                Duration = 120,
                AvailableSeats = 40,
                ReservedSeats = 23,
                MovieId = 1
            };

            var s2 = new Screening
            {
                Id = 2,
                Name = "Screening 2",
                StartTime = DateTime.Now.AddDays(10).AddHours(5),
                Duration = 80,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s3 = new Screening
            {
                Id = 3,
                Name = "Screening 3",
                StartTime = DateTime.Now.AddDays(11).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 13,
                MovieId = 1
            };

            var s4 = new Screening
            {
                Id = 4,
                Name = "Screening 4",
                StartTime = DateTime.Now.AddDays(10).AddHours(5),
                Duration = 80,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s5 = new Screening
            {
                Id = 5,
                Name = "Screening 5",
                StartTime = DateTime.Now.AddDays(12).AddHours(5),
                Duration = 80,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s6 = new Screening
            {
                Id = 6,
                Name = "Screening 6",
                StartTime = DateTime.Now.AddDays(13).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s7 = new Screening
            {
                Id = 7,
                Name = "Screening 7",
                StartTime = DateTime.Now.AddDays(10).AddHours(2),
                Duration = 120,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s8 = new Screening
            {
                Id = 8,
                Name = "Screening 8",
                StartTime = DateTime.Now.AddDays(11).AddHours(4),
                Duration = 120,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s9 = new Screening
            {
                Id = 9,
                Name = "Screening 9",
                StartTime = DateTime.Now.AddDays(11).AddHours(6),
                Duration = 120,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s10 = new Screening
            {
                Id = 10,
                Name = "Screening 10",
                StartTime = DateTime.Now.AddDays(13).AddHours(6),
                Duration = 120,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 1
            };

            var s11 = new Screening
            {
                Id = 11,
                Name = "Screening 11",
                StartTime = DateTime.Now.AddDays(15).AddHours(6),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s12 = new Screening
            {
                Id = 12,
                Name = "Screening 12",
                StartTime = DateTime.Now.AddDays(15).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s13 = new Screening
            {
                Id = 13,
                Name = "Screening 13",
                StartTime = DateTime.Now.AddDays(15).AddHours(-2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 9,
                MovieId = 3
            };

            var s14 = new Screening
            {
                Id = 14,
                Name = "Screening 14",
                StartTime = DateTime.Now.AddDays(17).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s15= new Screening
            {
                Id = 15,
                Name = "Screening 15",
                StartTime = DateTime.Now.AddDays(17).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s16 = new Screening
            {
                Id = 16,
                Name = "Screening 16",
                StartTime = DateTime.Now.AddDays(18).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 20
            };

            var s17 = new Screening
            {
                Id = 17,
                Name = "Screening 17",
                StartTime = DateTime.Now.AddDays(12).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 20
            };

            var s18 = new Screening
            {
                Id = 18,
                Name = "Screening 18",
                StartTime = DateTime.Now.AddDays(10).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 22
            };

            var s19 = new Screening
            {
                Id = 19,
                Name = "Screening 19",
                StartTime = DateTime.Now.AddDays(10).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 22
            };

            var s20 = new Screening
            {
                Id = 20,
                Name = "Screening 20",
                StartTime = DateTime.Now.AddDays(13).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 22
            };

            var s21 = new Screening
            {
                Id = 21,
                Name = "Screening 21",
                StartTime = DateTime.Now.AddDays(14).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 22
            };

            var s22 = new Screening
            {
                Id = 22,
                Name = "Screening 22",
                StartTime = DateTime.Now.AddDays(13).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 1,
                MovieId = 30
            };

            var s23 = new Screening
            {
                Id = 23,
                Name = "Screening 23",
                StartTime = DateTime.Now.AddDays(13).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s24 = new Screening
            {
                Id = 24,
                Name = "Screening 24",
                StartTime = DateTime.Now.AddDays(15).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s25 = new Screening
            {
                Id = 25,
                Name = "Screening 25",
                StartTime = DateTime.Now.AddDays(15).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s26 = new Screening
            {
                Id = 26,
                Name = "Screening 26",
                StartTime = DateTime.Now.AddDays(13).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s27 = new Screening
            {
                Id = 27,
                Name = "Screening 27",
                StartTime = DateTime.Now.AddDays(13).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 50
            };

            var s28 = new Screening
            {
                Id = 28,
                Name = "Screening 28",
                StartTime = DateTime.Now.AddDays(19).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 50
            };

            var s29 = new Screening
            {
                Id = 29,
                Name = "Screening 29",
                StartTime = DateTime.Now.AddDays(17).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 44
            };

            var s30 = new Screening
            {
                Id = 30,
                Name = "Screening 30",
                StartTime = DateTime.Now.AddDays(17).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 44
            };

            var s31 = new Screening
            {
                Id = 31,
                Name = "Screening 31",
                StartTime = DateTime.Now.AddDays(17).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 7,
                MovieId = 33
            };

            var s32 = new Screening
            {
                Id = 32,
                Name = "Screening 32",
                StartTime = DateTime.Now.AddDays(16).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 62
            };

            var s33 = new Screening
            {
                Id = 33,
                Name = "Screening 33",
                StartTime = DateTime.Now.AddDays(20).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 62
            };

            var s34 = new Screening
            {
                Id = 34,
                Name = "Screening 34",
                StartTime = DateTime.Now.AddDays(22).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 62
            };

            var s35 = new Screening
            {
                Id = 35,
                Name = "Screening 35",
                StartTime = DateTime.Now.AddDays(21).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 89
            };

            var s36 = new Screening
            {
                Id = 36,
                Name = "Screening 36",
                StartTime = DateTime.Now.AddDays(21).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 10,
                MovieId = 21
            };

            var s37 = new Screening
            {
                Id = 37,
                Name = "Screening 37",
                StartTime = DateTime.Now.AddDays(24).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 77
            };

            var s38 = new Screening
            {
                Id = 38,
                Name = "Screening 38",
                StartTime = DateTime.Now.AddDays(14).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 89
            };

            var s39 = new Screening
            {
                Id = 39,
                Name = "Screening 39",
                StartTime = DateTime.Now.AddDays(17).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 89
            };

            var s40 = new Screening
            {
                Id = 40,
                Name = "Screening 40",
                StartTime = DateTime.Now.AddDays(16).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 62
            };

            var s41 = new Screening
            {
                Id = 41,
                Name = "Screening 41",
                StartTime = DateTime.Now.AddDays(26).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 45
            };

            var s42 = new Screening
            {
                Id = 42,
                Name = "Screening 42",
                StartTime = DateTime.Now.AddDays(21).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 45
            };

            var s43 = new Screening
            {
                Id = 43,
                Name = "Screening 43",
                StartTime = DateTime.Now.AddDays(25).AddHours(-3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 88
            };

            var s44 = new Screening
            {
                Id = 44,
                Name = "Screening 44",
                StartTime = DateTime.Now.AddDays(26).AddHours(-1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 6,
                MovieId = 42
            };

            var s45 = new Screening
            {
                Id = 45,
                Name = "Screening 45",
                StartTime = DateTime.Now.AddDays(31).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 58
            };

            var s46 = new Screening
            {
                Id = 46,
                Name = "Screening 46",
                StartTime = DateTime.Now.AddDays(22).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 58
            };

            var s47 = new Screening
            {
                Id = 47,
                Name = "Screening 47",
                StartTime = DateTime.Now.AddDays(21).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 58
            };

            var s48 = new Screening
            {
                Id = 48,
                Name = "Screening 48",
                StartTime = DateTime.Now.AddDays(21).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 58
            };

            var s49 = new Screening
            {
                Id = 49,
                Name = "Screening 49",
                StartTime = DateTime.Now.AddDays(27).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 58
            };

            var s50 = new Screening
            {
                Id = 50,
                Name = "Screening 50",
                StartTime = DateTime.Now.AddDays(22).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 47
            };

            var s51 = new Screening
            {
                Id = 51,
                Name = "Screening 51",
                StartTime = DateTime.Now.AddDays(15).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 46
            };

            var s52 = new Screening
            {
                Id = 52,
                Name = "Screening 52",
                StartTime = DateTime.Now.AddDays(16).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 71
            };

            var s53 = new Screening
            {
                Id = 53,
                Name = "Screening 53",
                StartTime = DateTime.Now.AddDays(16).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 54
            };

            var s54 = new Screening
            {
                Id = 54,
                Name = "Screening 54",
                StartTime = DateTime.Now.AddDays(18).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s55 = new Screening
            {
                Id = 55,
                Name = "Screening 55",
                StartTime = DateTime.Now.AddDays(33).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s56 = new Screening
            {
                Id = 56,
                Name = "Screening 56",
                StartTime = DateTime.Now.AddDays(33).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s57 = new Screening
            {
                Id = 57,
                Name = "Screening 57",
                StartTime = DateTime.Now.AddDays(23).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s58 = new Screening
            {
                Id = 58,
                Name = "Screening 58",
                StartTime = DateTime.Now.AddDays(33).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s59 = new Screening
            {
                Id = 59,
                Name = "Screening 59",
                StartTime = DateTime.Now.AddDays(37).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 34
            };

            var s60 = new Screening
            {
                Id = 60,
                Name = "Screening 60",
                StartTime = DateTime.Now.AddDays(51).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 52
            };

            var s61 = new Screening
            {
                Id = 61,
                Name = "Screening 61",
                StartTime = DateTime.Now.AddDays(29).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 54
            };

            var s62 = new Screening
            {
                Id = 62,
                Name = "Screening 62",
                StartTime = DateTime.Now.AddDays(55).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 8,
                MovieId = 63
            };

            var s63 = new Screening
            {
                Id = 63,
                Name = "Screening 63",
                StartTime = DateTime.Now.AddDays(41).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 63
            };

            var s64 = new Screening
            {
                Id = 64,
                Name = "Screening 64",
                StartTime = DateTime.Now.AddDays(33).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 63
            };

            var s65 = new Screening
            {
                Id = 65,
                Name = "Screening 65",
                StartTime = DateTime.Now.AddDays(43).AddHours(6),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 68
            };

            var s66 = new Screening
            {
                Id = 66,
                Name = "Screening 66",
                StartTime = DateTime.Now.AddDays(21).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 47
            };

            var s67 = new Screening
            {
                Id = 67,
                Name = "Screening 67",
                StartTime = DateTime.Now.AddDays(44).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 67
            };

            var s68 = new Screening
            {
                Id = 68,
                Name = "Screening 68",
                StartTime = DateTime.Now.AddDays(59).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 39
            };

            var s69 = new Screening
            {
                Id = 69,
                Name = "Screening 69",
                StartTime = DateTime.Now.AddDays(37).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 39
            };

            var s70 = new Screening
            {
                Id = 70,
                Name = "Screening 70",
                StartTime = DateTime.Now.AddDays(42).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 37
            };

            var s71 = new Screening
            {
                Id = 71,
                Name = "Screening 71",
                StartTime = DateTime.Now.AddDays(22).AddHours(6),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 44
            };

            var s72 = new Screening
            {
                Id = 72,
                Name = "Screening 72",
                StartTime = DateTime.Now.AddDays(55).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 66
            };

            var s73 = new Screening
            {
                Id = 73,
                Name = "Screening 73",
                StartTime = DateTime.Now.AddDays(33).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 66
            };

            var s74 = new Screening
            {
                Id = 74,
                Name = "Screening 74",
                StartTime = DateTime.Now.AddDays(32).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 9,
                MovieId = 81
            };

            var s75 = new Screening
            {
                Id = 75,
                Name = "Screening 75",
                StartTime = DateTime.Now.AddDays(11).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 55
            };

            var s76 = new Screening
            {
                Id = 76,
                Name = "Screening 76",
                StartTime = DateTime.Now.AddDays(66).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s77 = new Screening
            {
                Id = 77,
                Name = "Screening 77",
                StartTime = DateTime.Now.AddDays(22).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 59
            };

            var s78 = new Screening
            {
                Id = 78,
                Name = "Screening 78",
                StartTime = DateTime.Now.AddDays(47).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 64
            };

            var s79 = new Screening
            {
                Id = 79,
                Name = "Screening 79",
                StartTime = DateTime.Now.AddDays(38).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 89
            };

            var s80 = new Screening
            {
                Id = 80,
                Name = "Screening 80",
                StartTime = DateTime.Now.AddDays(19).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 100
            };

            var s81 = new Screening
            {
                Id = 81,
                Name = "Screening 81",
                StartTime = DateTime.Now.AddDays(43).AddHours(4),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s82 = new Screening
            {
                Id = 82,
                Name = "Screening 82",
                StartTime = DateTime.Now.AddDays(38).AddHours(-1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s83 = new Screening
            {
                Id = 83,
                Name = "Screening 83",
                StartTime = DateTime.Now.AddDays(31).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 3
            };

            var s84 = new Screening
            {
                Id = 84,
                Name = "Screening 84",
                StartTime = DateTime.Now.AddDays(32).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 4
            };

            var s85 = new Screening
            {
                Id = 85,
                Name = "Screening 85",
                StartTime = DateTime.Now.AddDays(26).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 5
            };

            var s86 = new Screening
            {
                Id = 86,
                Name = "Screening 86",
                StartTime = DateTime.Now.AddDays(26).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 5
            };

            var s87 = new Screening
            {
                Id = 87,
                Name = "Screening 87",
                StartTime = DateTime.Now.AddDays(32).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 43
            };

            var s88 = new Screening
            {
                Id = 88,
                Name = "Screening 88",
                StartTime = DateTime.Now.AddDays(27).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 65
            };

            var s89 = new Screening
            {
                Id = 89,
                Name = "Screening 89",
                StartTime = DateTime.Now.AddDays(67).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 96
            };

            var s90 = new Screening
            {
                Id = 90,
                Name = "Screening 90",
                StartTime = DateTime.Now.AddDays(43).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 53
            };

            var s91 = new Screening
            {
                Id = 91,
                Name = "Screening 91",
                StartTime = DateTime.Now.AddDays(41).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 36
            };

            var s92 = new Screening
            {
                Id = 92,
                Name = "Screening 92",
                StartTime = DateTime.Now.AddDays(24).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 49
            };

            var s93 = new Screening
            {
                Id = 93,
                Name = "Screening 93",
                StartTime = DateTime.Now.AddDays(42).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 49
            };

            var s94 = new Screening
            {
                Id = 94,
                Name = "Screening 94",
                StartTime = DateTime.Now.AddDays(24).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 35
            };

            var s95 = new Screening
            {
                Id = 95,
                Name = "Screening 95",
                StartTime = DateTime.Now.AddDays(24).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 72
            };

            var s96 = new Screening
            {
                Id = 96,
                Name = "Screening 96",
                StartTime = DateTime.Now.AddDays(24).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 28
            };

            var s97 = new Screening
            {
                Id = 97,
                Name = "Screening 97",
                StartTime = DateTime.Now.AddDays(53).AddHours(1),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 31
            };

            var s98 = new Screening
            {
                Id = 98,
                Name = "Screening 98",
                StartTime = DateTime.Now.AddDays(23).AddHours(5),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 49
            };

            var s99 = new Screening
            {
                Id = 99,
                Name = "Screening 99",
                StartTime = DateTime.Now.AddDays(47).AddHours(2),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 53
            };

            var s100 = new Screening
            {
                Id = 100,
                Name = "Screening 100",
                StartTime = DateTime.Now.AddDays(26).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 49
            };

            var s101 = new Screening
            {
                Id = 101,
                Name = "Screening 101",
                StartTime = DateTime.Now.AddDays(35).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 0,
                MovieId = 99
            };

            var s102 = new Screening
            {
                Id = 102,
                Name = "Screening 102",
                StartTime = DateTime.Now.AddDays(22).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 7,
                MovieId = 102
            };

            var s103 = new Screening
            {
                Id = 103,
                Name = "Screening 103",
                StartTime = DateTime.Now.AddDays(25).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 4,
                MovieId = 103
            };

            var s104 = new Screening
            {
                Id = 104,
                Name = "Screening 104",
                StartTime = DateTime.Now.AddDays(24).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 5,
                MovieId = 104
            };

            var s105 = new Screening
            {
                Id = 105,
                Name = "Screening 105",
                StartTime = DateTime.Now.AddDays(26).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 2,
                MovieId = 105
            };

            var s106 = new Screening
            {
                Id = 106,
                Name = "Screening 106",
                StartTime = DateTime.Now.AddDays(27).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 2,
                MovieId = 106
            };

            var s107 = new Screening
            {
                Id = 107,
                Name = "Screening 107",
                StartTime = DateTime.Now.AddDays(30).AddHours(3),
                Duration = 100,
                AvailableSeats = 40,
                ReservedSeats = 1,
                MovieId = 107
            };
            #endregion

            #region Tickets
            var t1 = new Ticket
            {
                Id = 1,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t2 = new Ticket
            {
                Id = 2,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t3 = new Ticket
            {
                Id = 3,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t4 = new Ticket
            {
                Id = 4,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t5 = new Ticket
            {
                Id = 5,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t6 = new Ticket
            {
                Id = 6,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t7 = new Ticket
            {
                Id = 7,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t8 = new Ticket
            {
                Id = 8,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t9 = new Ticket
            {
                Id = 9,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t10 = new Ticket
            {
                Id = 10,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t11 = new Ticket
            {
                Id = 11,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t12 = new Ticket
            {
                Id = 12,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t13 = new Ticket
            {
                Id = 13,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t14 = new Ticket
            {
                Id = 14,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t15 = new Ticket
            {
                Id = 15,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t16 = new Ticket
            {
                Id = 16,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t17 = new Ticket
            {
                Id = 17,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t18 = new Ticket
            {
                Id = 18,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t19 = new Ticket
            {
                Id = 19,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t20 = new Ticket
            {
                Id = 20,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t21 = new Ticket
            {
                Id = 21,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t22 = new Ticket
            {
                Id = 22,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t23 = new Ticket
            {
                Id = 23,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 1
            };

            var t24 = new Ticket
            {
                Id = 24,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t25 = new Ticket
            {
                Id = 25,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t26 = new Ticket
            {
                Id = 26,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t27 = new Ticket
            {
                Id = 27,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t28 = new Ticket
            {
                Id = 28,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t29 = new Ticket
            {
                Id = 29,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t30 = new Ticket
            {
                Id = 30,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t31 = new Ticket
            {
                Id = 31,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t32 = new Ticket
            {
                Id = 32,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t33 = new Ticket
            {
                Id = 33,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t34 = new Ticket
            {
                Id = 34,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t35 = new Ticket
            {
                Id = 35,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t36 = new Ticket
            {
                Id = 36,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 3
            };

            var t37 = new Ticket
            {
                Id = 37,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t38 = new Ticket
            {
                Id = 38,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t39 = new Ticket
            {
                Id = 39,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t40 = new Ticket
            {
                Id = 40,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t41 = new Ticket
            {
                Id = 41,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t42 = new Ticket
            {
                Id = 42,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t43 = new Ticket
            {
                Id = 43,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t44 = new Ticket
            {
                Id = 44,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t45 = new Ticket
            {
                Id = 45,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 13
            };

            var t46 = new Ticket
            {
                Id = 46,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t47 = new Ticket
            {
                Id = 47,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t48 = new Ticket
            {
                Id = 48,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t49 = new Ticket
            {
                Id = 49,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t50 = new Ticket
            {
                Id = 50,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t51 = new Ticket
            {
                Id = 51,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t52 = new Ticket
            {
                Id = 52,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t53 = new Ticket
            {
                Id = 53,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t54 = new Ticket
            {
                Id = 54,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t55 = new Ticket
            {
                Id = 55,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t56 = new Ticket
            {
                Id = 56,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 25
            };

            var t57 = new Ticket
            {
                Id = 57,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t58 = new Ticket
            {
                Id = 58,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t59 = new Ticket
            {
                Id = 59,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t60 = new Ticket
            {
                Id = 60,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t61 = new Ticket
            {
                Id = 61,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t62 = new Ticket
            {
                Id = 62,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t63 = new Ticket
            {
                Id = 63,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 31
            };

            var t64 = new Ticket
            {
                Id = 64,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t65 = new Ticket
            {
                Id = 65,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t66 = new Ticket
            {
                Id = 66,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t67 = new Ticket
            {
                Id = 67,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t68 = new Ticket
            {
                Id = 68,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t69 = new Ticket
            {
                Id = 69,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t70 = new Ticket
            {
                Id = 70,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t71 = new Ticket
            {
                Id = 71,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 62
            };

            var t72 = new Ticket
            {
                Id = 72,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t73 = new Ticket
            {
                Id = 73,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t74 = new Ticket
            {
                Id = 74,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t75 = new Ticket
            {
                Id = 75,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t76 = new Ticket
            {
                Id = 76,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t77 = new Ticket
            {
                Id = 77,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 44
            };

            var t78 = new Ticket
            {
                Id = 78,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t79 = new Ticket
            {
                Id = 79,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t80 = new Ticket
            {
                Id = 80,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t81 = new Ticket
            {
                Id = 81,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t82 = new Ticket
            {
                Id = 82,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t83 = new Ticket
            {
                Id = 83,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t84 = new Ticket
            {
                Id = 84,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t85 = new Ticket
            {
                Id = 85,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t86 = new Ticket
            {
                Id = 86,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t87 = new Ticket
            {
                Id = 87,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 36
            };

            var t88 = new Ticket
            {
                Id = 88,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t89 = new Ticket
            {
                Id = 89,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t90 = new Ticket
            {
                Id = 90,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t91 = new Ticket
            {
                Id = 91,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t92 = new Ticket
            {
                Id = 92,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t93 = new Ticket
            {
                Id = 93,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t94 = new Ticket
            {
                Id = 94,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t95 = new Ticket
            {
                Id = 95,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t96 = new Ticket
            {
                Id = 96,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 74
            };

            var t97 = new Ticket
            {
                Id = 97,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 61
            };

            var t98 = new Ticket
            {
                Id = 98,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 61
            };

            var t99 = new Ticket
            {
                Id = 99,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 61
            };

            var t100 = new Ticket
            {
                Id = 100,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 61
            };

            var t101 = new Ticket
            {
                Id = 101,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 22
            };

            var t102 = new Ticket
            {
                Id = 102,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t103 = new Ticket
            {
                Id = 103,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t104 = new Ticket
            {
                Id = 104,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t105 = new Ticket
            {
                Id = 105,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t106 = new Ticket
            {
                Id = 106,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t107 = new Ticket
            {
                Id = 107,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t108 = new Ticket
            {
                Id = 108,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 102
            };

            var t109 = new Ticket
            {
                Id = 109,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 103
            };

            var t110 = new Ticket
            {
                Id = 110,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 103
            };

            var t111 = new Ticket
            {
                Id = 111,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 103
            };

            var t112 = new Ticket
            {
                Id = 112,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 103
            };

            var t113 = new Ticket
            {
                Id = 113,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 104
            };

            var t114 = new Ticket
            {
                Id = 114,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 104
            };

            var t115 = new Ticket
            {
                Id = 115,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 104
            };

            var t116 = new Ticket
            {
                Id = 116,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 104
            };

            var t117 = new Ticket
            {
                Id = 117,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 104
            };

            var t118 = new Ticket
            {
                Id = 118,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 105
            };

            var t119 = new Ticket
            {
                Id = 119,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 105
            };

            var t120 = new Ticket
            {
                Id = 120,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 106
            };

            var t121 = new Ticket
            {
                Id = 121,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 106
            };

            var t122 = new Ticket
            {
                Id = 122,
                Price = 7.99,
                UserId = 1,
                ScreeningId = 107
            };
            #endregion

            #region Users
            AuthRepository.CreatePasswordHash("password", out byte[] passwordHash, out byte[] passwordSalt);
            var u1 = new User
            {
                Id = 1,
                Name = "Administrator",
                Email = "admin@admin.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            #endregion

            modelBuilder.Entity<User>().HasData(
                u1 
            );

            modelBuilder.Entity<CastMember>().HasData(
                cm1, cm2, cm3, cm4, cm5, cm6, cm7, cm8, cm9, cm10, cm11,
                cm12, cm13, cm14, cm15, cm16, cm17, cm18, cm19, cm20, cm21, cm22,
                cm23, cm24, cm25, cm26, cm27, cm28, cm29, cm30, cm31, cm32, cm33,
                cm34, cm35, cm36, cm37, cm38, cm39, cm40, cm41, cm42, cm43, cm44,
                cm45, cm46, cm47, cm48, cm49, cm50, cm51, cm52, cm53, cm54, cm55,
                cm56, cm57, cm58, cm59, cm60
            );

            modelBuilder.Entity<Movie>().HasData(
                m1, m2, m3, m4, m5, m6, m7, m8, m9, m10,
                m11, m12, m13, m14, m15, m16, m17, m18, m19, m20,
                m21, m22, m23, m24, m25, m26, m27, m28, m29, m30,
                m31, m32, m33, m34, m35, m36, m37, m38, m39, m40,
                m41, m42, m43, m44, m45, m46, m47, m48, m49, m50,
                m51, m52, m53, m54, m55, m56, m57, m58, m59, m60,
                m61, m62, m63, m64, m65, m66, m67, m68, m69, m70,
                m71, m72, m73, m74, m75, m76, m77, m78, m79, m80,
                m81, m82, m83, m84, m85, m86, m87, m88, m89, m90,
                m91, m92, m93, m94, m95, m96, m97, m98, m99, m100,
                m101, m102, m103, m104, m105, m106, m107
            );

            modelBuilder.Entity<Rating>().HasData(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                r41, r42, r43, r44, r45, r46, r47, r48, r49, r50,
                r51, r52, r53, r54, r55, r56, r57, r58, r59, r60,
                r61, r62, r63, r64, r65, r66, r67, r68, r69, r70,
                r71, r72, r73, r74, r75, r76, r77, r78, r79, r80,
                r81, r82, r83, r84, r85, r86, r87, r88, r89, r90,
                r91, r92, r93, r94, r95, r96, r97, r98, r99, r100,
                r101
            );

            modelBuilder.Entity<Ticket>().HasData(
                t1, t2, t3, t4, t5, t6, t7, t8, t9, t10,
                t11, t12, t13, t14, t15, t16, t17, t18, t19, t20,
                t21, t22, t23, t24, t25, t26, t27, t28, t29, t30,
                t31, t32, t33, t34, t35, t36, t37, t38, t39, t40,
                t41, t42, t43, t44, t45, t46, t47, t48, t49, t50,
                t51, t52, t53, t54, t55, t56, t57, t58, t59, t60,
                t61, t62, t63, t64, t65, t66, t67, t68, t69, t70,
                t71, t72, t73, t74, t75, t76, t77, t78, t79, t80,
                t81, t82, t83, t84, t85, t86, t87, t88, t89, t90,
                t91, t92, t93, t94, t95, t96, t97, t98, t99, t100,
                t101, t102, t103, t104, t105, t106, t107, t108, t109, t110,
                t111, t112, t113, t114, t115, t116, t117, t118, t119, t120,
                t121, t122
            );

            modelBuilder.Entity<Screening>().HasData(
                s1, s2, s3, s4, s5, s6, s7, s8, s9, s10,
                s11, s12, s13, s14, s15, s16, s17, s18, s19, s20,
                s21, s22, s23, s24, s25, s26, s27, s28, s29, s30,
                s31, s32, s33, s34, s35, s36, s37, s38, s39, s40,
                s41, s42, s43, s44, s45, s46, s47, s48, s49, s50,
                s51, s52, s53, s54, s55, s56, s57, s58, s59, s60,
                s61, s62, s63, s64, s65, s66, s67, s68, s69, s70,
                s71, s72, s73, s74, s75, s76, s77, s78, s79, s80,
                s81, s82, s83, s84, s85, s86, s87, s88, s89, s90,
                s91, s92, s93, s94, s95, s96, s97, s98, s99, s100,
                s101, s102, s103, s104, s105, s106, s107
            );

            modelBuilder.Entity<MostSoldMoviesWithoutRatingsResult>().HasNoKey();
            modelBuilder.Entity<Top10MoviesByScreeningsForPeriodResult>().HasNoKey();
            modelBuilder.Entity<Top10MoviesByRatingResult>().HasNoKey();
        }
    }
}