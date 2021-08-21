using System;
using System.Collections.Generic;
using System.Text;
using Servises;
using Model;

namespace MVVM
{
    public class SchoolViewModel : ViewModelBase
    {
        private SchoolService _service;
        private Child _selectedChild;
        private Group _selectedGroup;
        private RelayCommand _addChildToGroup;

        public SchoolViewModel(SchoolService service)
        {
            _service = service;
        }

        public Child SelectedChild
        {
            get
            {
                return _selectedChild;
            }
            set
            {
                _selectedChild = value;
                OnPropertyChanged(nameof(SelectedChild));
            }
        }
        public Group SelectedGroup
        {
            get
            {
                return _selectedGroup;
            }
            set
            {
                _selectedGroup = value;
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        public IEnumerable<Child> Chids
        {
            get
            {
                return _service.AllChild();
            }
        }

        public IEnumerable<Child> ChildInGroup
        {
            get
            {
                return _service.AllChildInGroup(_selectedGroup);
            }
        }

        public RelayCommand AddChildToGroup
        {
            get
            {
                return _addChildToGroup ?? new RelayCommand(obj =>
                {
                    _service.AddToBestGroup(SelectedChild);
                }, obj => SelectedChild != null);
            }
        }
    }
}
