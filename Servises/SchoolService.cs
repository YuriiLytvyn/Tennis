using System;
using Model;
using Data;
using Model.Childs;
using System.Collections.Generic;
namespace Servises
{
    public class SchoolService
    {

        StaticListRepository staticListRepository = new StaticListRepository();

        public void CreateGroup(Days day, LevelPrep level, Child child)
        {
            Group group = new Group(day, level, child);
            staticListRepository.AddGroup(group);
        }

        public void CreateChild(string name, int age, int level, Days day)
        {

            if (level == 1)
            {
                Child child = new BeginerChild(name, age, day);
                staticListRepository.AddChild(child);
                AddToBestGroup(child);
            }
            else if (level == 2)
            {
                Child child = new AmateurChild(name, age, day);
                staticListRepository.AddChild(child);
                AddToBestGroup(child);
            }
            else if (level == 3)
            {
                Child child = new ProfessionalChild(name, age, day);
                staticListRepository.AddChild(child);
                AddToBestGroup(child);
            }
        }

        public void AddToGroup(Guid idGroup, Child child)
        {
            staticListRepository.AddToGroup(idGroup, child);
        }
        public List<Group> AllGroups()
        {
            List<Group> groups = staticListRepository.GetAllGroup();
            return groups;
        }

        public List<Child> AllChild()
        {
            List<Child> childs = staticListRepository.GetAllChild();
            return childs;
        }
        public List<Child> AllChildInGroup(Group group)
        {
            List<Child> childs = staticListRepository.GetAllChildInGroup(group);
            return childs;
        }

        public void AddToBestGroup(Child child)
        {
            Days day = child.day;
            LevelPrep level = child.level;
            Group bestGroup = staticListRepository.GetBestGroup(day, level);
            if (bestGroup == null) CreateGroup(day, level, child);
            else
            {
                Guid idGroup = bestGroup.Id;
                AddToGroup(idGroup, child);
            }

        }


    }
}
