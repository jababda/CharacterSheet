using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterSheetManager
{
    public abstract class Character
    {
        protected string name;
        protected int health;

        protected string description;

        protected Dictionary<string, int> attributes;
        protected Dictionary<string, Item> inventory;
        protected Dictionary<string, int> skills;

        protected Dictionary<string, CharacterAction> characterActions;

        protected virtual void DoAction(string item)
        {
            
        }

        protected class CharacterAction
        {
            private Dictionary<string, int> linkedSkills;
            private Dictionary<string, Item> linkedItems;
            private string name;
            private string description;
            private Dictionary<string, object> tags;

            CharacterAction()
            {

            }
        }
    }
}
