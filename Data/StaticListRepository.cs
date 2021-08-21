using System;
using System.Collections.Generic;
using Model;

namespace Data
{
    public class StaticListRepository
    {
        static List<Group> groups = new List<Group>();
        static List<Child> childrens = new List<Child>();

        public void AddGroup(Group group)
        {
            groups.Add(group);
        }

        public List<Group> GetAllGroup()
        {
            return groups;
        }

        public List<Child> GetAllChild()
        {
            return childrens;
        }
        public List<Child> GetAllChildInGroup(Group group)
        {
            List<Child> childs = new List<Child>();
            foreach (Group group1 in groups.FindAll(_group => _group.Id == group.Id))
            {
                List<Child> children = group1.childrens;
                foreach(Child child in children)
                {
                    childs.Add(child);
                }
            }
            return childs;
        }

        public Group GetBestGroup(Days _day, LevelPrep _level)
        {
            return groups.FindAll(_group => _group.day == _day).FindAll(_group => _group.level == _level)
                .Find(_group => _group.numberChild <= 5);
        }
        public void AddToGroup(Guid id, Child child)
        {
            Group group = groups.Find(_group => _group.Id == id);
            group.numberChild += 1;
            group.AddChild(child);
        }

        public void AddChild(Child child)
        {
            childrens.Add(child);
        }
    }
}
