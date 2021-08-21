using System;

namespace Model
{
    public class Child : Base
    {
        public string Name { get; set; }
        public int age { get; set; }
        public LevelPrep level { get; set; }
        public Days day { get; set; }

        public Child(string _Name, int _age, Days _day)
        {
            this.Name = _Name;
            this.age = _age;
            //this.level = _level;
            this.day = _day;
        }



        public override string ToString()
        {
            return Name + ",  " + age + " years , " + level + " , day of visit : " + day;
        }


    }
}
