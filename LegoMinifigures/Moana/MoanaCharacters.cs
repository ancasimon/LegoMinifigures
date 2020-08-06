using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Moana
{
    class MoanaCharacters
    {
        //properties:
        public HairColor CharacterHairColor { get; }
    }

    enum HairColor
    {
        NotSet,
        Black,
        Blond,
        Brown,
        Red
    }

    enum HairLength
    {
        NotSet,
        Long,
        Short
    }

    enum EyeColor
    {
        NotSet,
        Black,
        Blue,
        Brown,
        Green
    }
}
