using LegoMinifigures.Frozen;
using LegoMinifigures.Moana;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Moana characters:
            var characterMoana1 = new MoanaCharacters("Moana", true, true, HairColor.Brown, HairLength.Long, EyeColor.Brown, Height.Petite);
            var characterMoana2 = new MoanaCharacters("Maui", true, false, HairColor.Brown, HairLength.Long, EyeColor.Black, Height.Tall);
            var characterMoana3 = new MoanaCharacters("Gramma Tala", true, true, HairColor.Grey, HairLength.Long, EyeColor.Brown, Height.Petite);
            var characterMoana4 = new MoanaCharacters("Tamatoa", false, false, HairColor.NotSet, HairLength.NotSet, EyeColor.Black, Height.Petite);


            characterMoana1.Jump();
            characterMoana2.Row();
            characterMoana3.Sing();
            characterMoana4.Attack();

            //Frozen characters:
            var characterFrozen1 = new FrozenCharacters("Elsa", true, "Queen", true);
            var characterFrozen2 = new FrozenCharacters("Olaf", false, "Entertaining Snowman", true);
            var characterFrozen3 = new FrozenCharacters("Kristoff", true, "ice cutter", false);


            if (characterFrozen1.Job == "Princess")
            {
                var characterFrozen4 = new FrozenCharacters("Anna", true, "Queen", false);
                characterFrozen4.Run();
            }
            else
            {
                var characterFrozen4 = new FrozenCharacters("Anna", true, "Princess", false);
                characterFrozen4.Run();
            }

            characterFrozen1.RideHorses();
            characterFrozen2.ReOrderBodyParts();
            characterFrozen3.TalksToReindeer();

        }
    }
}
