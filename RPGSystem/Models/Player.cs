using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Models
{
    public class Player : ModelBase
    {
        private string _name;
        private string _class;
        private string _skills;
        private string _items;

        /// <summary>
        /// Property that returns player's name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if(_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public string Class
        {
            get => _class;
            set
            {
                if (_class != value)
                {
                    _class = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Skills
        {
            get => _skills;
            set
            {
                if (_skills != value)
                {
                    _skills = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Items
        {
            get => _items;
            set
            {
                if (_items != value)
                {
                    _items = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
