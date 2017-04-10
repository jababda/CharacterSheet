using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterSheetManager
{
    public class Item
    {
        private string name;
        private Dictionary<string, object> tags;
        private string description;
        private Dictionary<string, int> effectedSkills;
        private Dictionary<string, int> effectedAttributes;
        private Dictionary<string, int> effectedItems;

        public string Name { get => name; set => name = value; }
        public Dictionary<string, object> Tags { get => tags;}

        
    }
}