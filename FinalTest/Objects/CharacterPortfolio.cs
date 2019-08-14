using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Student Name: Wenxu Kang
//Student ID:300943385
//Description:  the main container class for the app



namespace FinalTest.Objects
{
    public class CharacterPortfolio
    {


        //Identity
        public Identity Identity { get; set; }

        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }



        //Skill List
        List<Skill> Skills;

        //Constructor

        CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();
        }
    }
}
