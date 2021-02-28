using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder;

//Name : Tia Harris
//Course: APA
//Date: 02/25/2021
//Synopisys: 4.3 Code Exercise | API Application

namespace APIApplication
{
    public class APIConnect
    {

        private string url = "https://www.superheroapi.com/api.php/10225364572042463/";
        private string byName = "https://www.superheroapi.com/api.php/10225364572042463/search/";

        public APIConnect()
        {
        }

        public dynamic Connect(string url)
        {
            dynamic jo;
            using (WebClient wc = new WebClient())

            {
                string results = wc.DownloadString(url);
                jo = JObject.Parse(results);

            }
            return jo;

        }



        public Character GetCharacter(string id)
        {
            dynamic characterObject = Connect(url + id);

            string characterId = characterObject.id;
            string characterName = characterObject.name;
            Character heroVillain = new Character(characterName, characterId);

            return heroVillain;

        }

        public Character ByName(string name)
        {
            dynamic jo = Connect(byName + name);

            while (jo.results == null)
            {
                Console.WriteLine("This hero is not in the library");
                Console.WriteLine("Who is another hero would you like to search?");
                name = Console.ReadLine();
                jo = Connect(byName + name);

            }

            foreach (dynamic s in jo.results)
            {
                string heroName = s.name;
                string uid = s.id;

                Character heroVillain = new Character(heroName, uid);
                return heroVillain;

            }
            
            return null;
                
        }

        public List<PowerStats> ReturnPowerStats (string id)
        {
            List<PowerStats> powerstats = new List<PowerStats>();
            dynamic jo = Connect(url+id);

          //  foreach (dynamic p in jo.powerstats)
           // {
                string intelligence = jo.powerstats.intelligence;
                string strength = jo.powerstats.strength;
                string speed = jo.powerstats.speed;
                string durability = jo.powerstats.durability;
                string power = jo.powerstats.power;
                string combat = jo.powerstats.combat;

                PowerStats powers = new PowerStats(intelligence,strength,speed,durability,power,combat);
                powerstats.Add(powers);

          //  }


            return powerstats;
        }
    }
}
