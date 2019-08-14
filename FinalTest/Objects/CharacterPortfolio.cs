using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Objects
{
    public class CharacterPortfolio
    {
        public Identity Identity { get; set; }

        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        List<Skill> Skills;



        CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();
        }
    }
}
