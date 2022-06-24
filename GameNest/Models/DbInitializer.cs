using System;
using System.Collections.Generic;
using System.Linq;

namespace GameNest.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Games.Any())
            {
                return;
            }

            context.AddRange
                (
                    new Game { 
                        Id = Guid.NewGuid().ToString(),
                        Name = "It Takes Two", 
                        Price = decimal.Parse("24.97"),
                        OriginalPrice = decimal.Parse("49.95"),
                        Description = "Embark on the craziest journey of your life in It Takes Two. " +
                        "Invite a friend to join for free with Friend’s Pass and work together across " +
                        "a huge variety of gleefully disruptive gameplay challenges. Winner of GAME OF " +
                        "THE YEAR at the Game Awards 2021.",
                        LongDescription = "Embark on the craziest journey of your life in It Takes Two, " +
                        "a genre-bending platform adventure created purely for co-op. Invite a friend " +
                        "to join for free with Friend’s Pass and work together across a huge variety " +
                        "of gleefully disruptive gameplay challenges. Play as the clashing couple Cody " +
                        "and May, two humans turned into dolls by a magic spell. Together, trapped in a " +
                        "fantastical world where the unpredictable hides around every corner, they are " +
                        "reluctantly challenged with saving their fractured relationship.\n\n" + "Master " +
                        "unique and connected character abilities in every new level. Help each other " +
                        "across an abundance of unexpected obstacles and laugh-out-loud moments. Kick " +
                        "gangster squirrels’ furry tails, pilot a pair of underpants, DJ a buzzing night " +
                        "club, and bobsleigh through a magical snow globe. Embrace a heartfelt and hilarious " +
                        "story where narrative and gameplay weave into a uniquely metaphorical experience.\n\n" + 
                        "It Takes Two is developed by the award-winning studio Hazelight, the industry leader " +
                        "of cooperative play. They’re about to take you on a wild and wondrous ride where only " +
                        "one thing is for certain: we’re better together.",
                        ImageURL =  "/images/it_takes_two.jpg"
                    },
                    new Game
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "A Way Out",
                        Price = decimal.Parse("9.98"),
                        OriginalPrice = decimal.Parse("39.95"),
                        Description = "A Way Out is an exclusively co-op adventure where you play the role" +
                        " of one of two prisoners making their daring escape from prison.",
                        LongDescription = "From the creators of Brothers – A Tale of Two Sons comes A Way Out, " +
                        "an exclusively co-op adventure where you play the role of one of two prisoners making " +
                        "their daring escape from prison. What begins as a thrilling breakout quickly turns into " +
                        "an unpredictable, emotional adventure unlike anything seen or played before. A Way Out " +
                        "is an experience that must be played with two players. Each player controls one of the " +
                        "main characters, Leo and Vincent, in a reluctant alliance to break out of prison and gain" +
                        " their freedom.",
                        ImageURL = "/images/a_way_out.jpg"
                    },
                    new Game
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Raft",
                        Price = decimal.Parse("24.60"),
                        OriginalPrice = decimal.Parse("28.95"),
                        Description = "Raft throws you and your friends into an epic oceanic adventure! Alone or " +
                        "together, players battle to survive a perilous voyage across a vast sea! Gather debris, " +
                        "scavenge reefs and build your own floating home, but be wary of the man-eating sharks!",
                        LongDescription = "By yourself or with friends, your mission is to survive an epic oceanic " +
                        "adventure across a perilous sea! Gather debris to survive, expand your raft and set sail " +
                        "towards forgotten and dangerous islands! \n\n"+
                        "Trapped on a small raft with nothing but a hook made of old plastic, players awake on a vast," +
                        "blue ocean totally alone and with no land in sight! With a dry throat and an empty stomach," +
                        "survival will not be easy!",
                        ImageURL = "/images/raft.jpg"
                    },
                    new Game
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Dying Light 2 Stay Human",
                        Price = decimal.Parse("60.263"),
                        OriginalPrice = decimal.Parse("89.95"),
                        Description = "The virus won and civilization has fallen back to the Dark Ages. The City, one " +
                        "of the last human settlements, is on the brink of collapse. Use your agility and combat skills " +
                        "to survive, and reshape the world. Your choices matter.",
                        LongDescription = "Over twenty years ago in Harran, we fought the virus—and lost. Now, we’re " +
                        "losing again. The City, one of the last large human settlements, is torn by conflict. Civilization " +
                        "has fallen back into the Dark Ages. And yet, we still have hope.\n\n"+
                        "You are a wanderer with the power to change the fate of The City.But your exceptional abilities " +
                        "come at a price.Haunted by memories you cannot decipher, you set out to learn the truth… and find " +
                        "yourself in a combat zone.Hone your skills, as to defeat your enemies and make allies, you’ll need " +
                        "both fists and wits.Unravel the dark secrets behind the wielders of power, choose sides and decide " +
                        "your destiny.But wherever your actions take you, there's one thing you can never forget—stay human.",
                        ImageURL = "/images/dying_light_2.jpg"
                    },
                    new Game
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "ELDEN RING",
                        Price = decimal.Parse("89.95"),
                        OriginalPrice = decimal.Parse("89.95"),
                        Description = "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the " +
                        "power of the Elden Ring and become an Elden Lord in the Lands Between.",
                        LongDescription = "THE NEW FANTASY ACTION RPG.\nRise, Tarnished, and be guided by grace to brandish " +
                        "the power of the Elden Ring and become an Elden Lord in the Lands Between\n\n" +
                        "• A Vast World Full of Excitement\nA vast world where open fields with a variety of situations and " +
                        "huge dungeons with complex and three-dimensional designs are seamlessly connected. As you explore, " +
                        "the joy of discovering unknown and overwhelming threats await you, leading to a high sense of accomplishment.\n\n"+
                        "• Create your Own Character\nIn addition to customizing the appearance of your character, you can" +
                        " freely combine the weapons, armor, and magic that you equip. You can develop your character " +
                        "according to your play style, such as increasing your muscle strength to become a strong warrior, " +
                        "or mastering magic.\n\n" +
                        "• An Epic Drama Born from a Myth\nA multilayered story told in fragments. An epic drama in which the " +
                        "various thoughts of the characters intersect in the Lands Between.\n\n" +
                        "• Unique Online Play that Loosely Connects You to Others\nIn addition to multiplayer, where you can " +
                        "directly connect with other players and travel together, the game supports a unique asynchronous " +
                        "online element that allows you to feel the presence of others.",
                        ImageURL = "/images/elden_ring.jpg"
                    }
                );
            context.SaveChanges();
        }
        public static void ClearDatabase(AppDbContext context)
        {
            // disable all foreign keys
            //context.Database.ExecuteSqlCommand("EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? NOCHECK CONSTRAINT all'");

            context.RemoveRange(context);

            context.SaveChanges();
            return;
        }
    }

   
}