using System;

namespace LinqToObject
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string PIB { get; set; }
        public TheatricalCharacter TheatricalCharacter { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return string.Format(@"{1} ({2}) 
            амплуа:{3}", ActorId, PIB, DateOfBirth, TheatricalCharacter.ToString());
        }

    }

}

