using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Group : Base
    {

        public List<Child> childrens { get; set; }

        public Days day { get; set; }

        public LevelPrep level { get; set; }

        public int numberChild { get; set; }
        public void AddChild(Child child)
        {
            childrens.Add(child);
        }

        public Group(Days _day, LevelPrep _level, Child _child)
        {
            this.day = _day;
            this.level = _level;
            this.childrens = new List<Child>();
            this.childrens.Add(_child);
            this.numberChild = 1;

        }

        public override string ToString()
        {
            return level + ", day of visit : " + day;
        }

    }
}
