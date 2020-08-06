using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Frozen
{
    class FrozenCharacters
    {
        //properties:
        public string Name { get; set; }
        public string Job { get; set; }
        public bool HasSupernaturalPowers { get; set; }

        //fields:
        public bool _isHuman = true;

        //constructor:
        public FrozenCharacters(string name, bool isHuman, string job, bool hasSupernaturalPowers)
        {
            Name = name;
            _isHuman = isHuman;
            Job = job;
            HasSupernaturalPowers = hasSupernaturalPowers;
        }

        //methods:
        public void RideHorses()
        {
            throw new NotImplementedException();
        }

        public void ReOrderBodyParts()
        {
            throw new NotImplementedException();
        }

        public void TalksToReindeer()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
