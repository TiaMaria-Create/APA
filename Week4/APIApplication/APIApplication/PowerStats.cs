using System;
namespace APIApplication

    //Name : Tia Harris
    //Course: APA
    //Date: 02/25/2021
    //Synopisys: 4.3 Code Exercise | API Application

{
    public class PowerStats
    {

        private string _intelligence;
        private string _strength;
        private string _speed;
        private string _durability;
        private string _power;
        private string _combat;


        public string Intelligence { get { return _intelligence; } }
        public string Strength { get { return _strength; } }
        public string Speed { get { return _speed; } }
        public string Durable { get { return _durability; } }
        public string Power { get { return _power; } }
        public string Combat { get { return _combat; } }
  

        public PowerStats(string intelligence, string strength, string speed, string durable, string power, string combat)
        {
            _intelligence = intelligence;
            _strength = strength;
            _speed = speed;
            _durability = durable;
            _power = power;
            _combat = combat;
        }
    }
}
