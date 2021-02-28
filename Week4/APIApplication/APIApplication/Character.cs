using System;
namespace APIApplication

//Name : Tia Harris
//Course: APA
//Date: 02/25/2021
//Synopisys: 4.3 Code Exercise | API Application

{
    public class Character
    {
        private string _characterID;
        private string _name;

       public string CharacterID { get {return _characterID; } }
        public string Name { get {return _name; } }

        public Character(string name, string id)
        {
            _characterID = id;
            _name = name;
        }
    }
}
