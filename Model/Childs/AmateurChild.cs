using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Childs
{
    public class AmateurChild : Child
    {
        public AmateurChild(string _Name, int _age, Days _day) : base(_Name, _age, _day)
        {
            this.level = LevelPrep.Amateur;
        }
    }
}
