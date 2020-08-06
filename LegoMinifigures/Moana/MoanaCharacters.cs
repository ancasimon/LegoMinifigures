using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Moana
{
    class MoanaCharacters
    {
        //properties:
        public string Name { get; }
        public HairColor CharacterHairColor { get; }
        public HairLength CharacterHairLength { get; }
        public EyeColor CharacterEyeColor { get; }
        public Height CharacterHeight { get; }

        //fields:
        private bool _isHuman = true;
        private bool _isFemale = true;

        //constructor:
        public MoanaCharacters(string name, bool isHuman, bool isFemale, HairColor characterHairColor, HairLength characterHairLength, EyeColor characterEyeColor, Height characterHeight)
        {
            Name = name;
            _isHuman = isHuman;
            _isFemale = isFemale;
            CharacterHairColor = characterHairColor;
            CharacterHairLength = characterHairLength;
            CharacterEyeColor = characterEyeColor;
            CharacterHeight = characterHeight;
        }

        //methods:
        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void Row()
        {
            throw new NotImplementedException();
        }

        public void Sing()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }

    enum HairColor
    {
        NotSet,
        Black,
        Blond,
        Brown,
        Grey, 
        Red
    }

    enum HairLength
    {
        NotSet,
        Long,
        Medium,
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

    enum Height
    {
        NotSet,
        Petite,
        Average,
        Tall,
    }
}
