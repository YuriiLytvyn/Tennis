using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Childs
{
    public class BeginerChild : Child
    {
        public BeginerChild(string _Name, int _age, Days _day) : base(_Name, _age, _day)
        {
            this.level = LevelPrep.Beginner;
        }
    }
}
