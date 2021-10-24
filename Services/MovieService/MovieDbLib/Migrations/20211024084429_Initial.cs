using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDbLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.InsertData(
                table: "movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "Language", "Length", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 0, "After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face a new enemy, Carnage, the alter ego of serial killer Cletus Kasady.", "en", 100, "2021-09-30", "Venom: Let There Be Carnage" },
                    { 18, 0, "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.", "en", 100, "2021-07-28", "The Suicide Squad" },
                    { 17, 0, "Shang-Chi must confront the past he thought he left behind when he is drawn into the web of the mysterious Ten Rings organization.", "en", 100, "2021-09-01", "Shang-Chi and the Legend of the Ten Rings" },
                    { 16, 0, "Peace and tranquility have set in Belogorie. The evil was defeated and Ivan is now enjoying his well-deserved fame. He is surrounded by his family, friends and small wonders from the modern world that help him lead a comfortable life. Luckily, he has his Magic Sword to cut a gap between the worlds to get some supplies quite regularly. But when an ancient evil rises and the existence of the magic world is put to danger, Ivan has to team up with his old friends and his new rivals. They will set out on a long journey beyond the known world to find a way to defeat the enemies and to return peace to Belogorie.", "ru", 100, "2021-01-01", "The Last Warrior: Root of Evil" },
                    { 15, 0, "Just as Tessa's life begins to become unglued, nothing is what she thought it would be. Not her friends nor her family. The only person that she should be able to rely on is Hardin, who is furious when he discovers the massive secret that she's been keeping. Before Tessa makes the biggest decision of her life, everything changes because of revelations about her family.", "en", 100, "2021-09-01", "After We Fell" },
                    { 14, 0, "When Lois Lane is killed, an unhinged Superman decides to take control of the Earth. Determined to stop him, Batman creates a team of freedom-fighting heroes. But when superheroes go to war, can the world survive?", "en", 100, "2021-10-09", "Injustice" },
                    { 13, 0, "In the Forest of Okoya, Koko is a feral child who has been raised as a Pokémon by the Mythical Pokémon Zarude. Koko has grown up never doubting that he is a Pokémon even though he can't really use any sort of moves. Ash Ketchum and Pikachu meet Koko and help him protect the Great Tree from the crooked scientist Dr. Zed.", "ja", 100, "2020-12-25", "Pokémon the Movie: Secrets of the Jungle" },
                    { 12, 0, "In the near future on a colony of state-of-the-art robots, a private investigator is hired by the colony's creator to bring his missing daughter home.", "en", 100, "2021-09-03", "Zone 414" },
                    { 11, 0, "Ahead of a promotion, a police chief becomes entangled in a deadly incident and uncovers an intrigue fueled by grudge that threatens his colleagues.", "tr", 100, "2021-10-08", "Grudge" },
                    { 10, 0, "The assassin Deathstroke tries to save his family from the wrath of H.I.V.E. and the murderous Jackal.", "en", 100, "2020-08-04", "Deathstroke: Knights & Dragons - The Movie" },
                    { 9, 0, "Faced with the unexpected death of his estranged father -El Máscara- and the subsequent theft of his precious mask, Rubén -Mascarita- will find himself confronted with his past. Alongside his invincible bodyguard Tony \"The Cannibal\" and, an unexpected ally, he will have only one day to recover it and make amends with the memory of his father.", "es", 100, "2021-10-01", "Matando Cabos 2: La Máscara del Máscara" },
                    { 8, 0, "After saving the life of their heir apparent, tenacious loner Snake Eyes is welcomed into an ancient Japanese clan called the Arashikage where he is taught the ways of the ninja warrior. But, when secrets from his past are revealed, Snake Eyes' honor and allegiance will be tested – even if that means losing the trust of those closest to him.", "en", 100, "2021-07-22", "Snake Eyes: G.I. Joe Origins" },
                    { 7, 0, "The Addams get tangled up in more wacky adventures and find themselves involved in hilarious run-ins with all sorts of unsuspecting characters.", "en", 100, "2021-10-01", "The Addams Family 2" },
                    { 6, 0, "With the help of the \"Dragon Sin of Wrath\" Meliodas and the worst rebels in history, the Seven Deadly Sins, the \"Holy War\", in which four races, including Humans, Goddesses, Fairies and Giants fought against the Demons, is finally over. At the cost of the \"Lion Sin of Pride\" Escanor's life, the Demon King was defeated and the world regained peace. After that, each of the Sins take their own path.", "ja", 100, "2021-07-02", "The Seven Deadly Sins: Cursed by Light" },
                    { 5, 0, "Investigative journalist Eddie Brock attempts a comeback following a scandal, but accidentally becomes the host of Venom, a violent, super powerful alien symbiote. Soon, he must rely on his newfound powers to protect the world from a shadowy organization looking for a symbiote of their own.", "en", 100, "2018-09-28", "Venom" },
                    { 4, 0, "A bank teller called Guy realizes he is a background character in an open world video game called Free City that will soon go offline.", "en", 100, "2021-08-11", "Free Guy" },
                    { 3, 0, "Minutes after Laurie Strode, her daughter Karen and granddaughter Allyson left masked monster Michael Myers caged and burning in Laurie's basement, Laurie is rushed to the hospital with life-threatening injuries, believing she finally killed her lifelong tormentor. But when Michael manages to free himself from Laurie's trap, his ritual bloodbath resumes. As Laurie fights her pain and prepares to defend herself against him, she inspires all of Haddonfield to rise up against their unstoppable monster. The Strode women join a group of other survivors of Michael's first rampage who decide to take matters into their own hands, forming a vigilante mob that sets out to hunt Michael down, once and for all.", "en", 100, "2021-10-14", "Halloween Kills" },
                    { 2, 0, "Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet's exclusive supply of the most precious resource in existence-a commodity capable of unlocking humanity's greatest potential-only those who can conquer their fear will survive.", "en", 100, "2021-09-15", "Dune" },
                    { 19, 0, "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to bring them together again … and inspire a new family business.", "en", 100, "2021-07-01", "The Boss Baby: Family Business" },
                    { 20, 0, "In the year 2524, four centuries after humans started colonizing the outer planets, retired General James Ford gets called back into service when a hostile alien fleet attacks soldiers on a remote planet. The threat against mankind soon escalates into an interstellar war as Ford and a team of elite soldiers try to stop the imminent attack before it's too late.", "en", 100, "2021-03-12", "Cosmic Sin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_presentation_MovieId",
                table: "presentation",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "presentation");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
