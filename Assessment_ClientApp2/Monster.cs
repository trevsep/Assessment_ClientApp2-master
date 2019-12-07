using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_ClientApp2
{
    /// <summary>
    /// monster entity class
    /// </summary>
    public class Monster
    {
        public enum EmotionalState
        {
            none,
            happy,
            sad,
            angry,
            content,
            sleepy,
            bored
        }

        public enum Tribe
        {
            none,
            Okishaba,
            Rickastley,
            Referees,
            Macdaddy
        }

        #region FIELDS

        private string _name;
        private int _age;
        private EmotionalState _attitude;
        private Tribe _tribe;
        private bool _active;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public EmotionalState Attitude
        {
            get { return _attitude; }
            set { _attitude = value; }
        }

        public Tribe tribe
        {
            get { return _tribe;  }
            set { _tribe = value; }
        }

        public bool Active
        {
            get { return _active;  }
            set { _active = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name, int age, EmotionalState attitude, Tribe tribe, bool active)
        {
            _name = name;
            _age = age;
            _attitude = attitude;
            _tribe = tribe;
            _active = active;
        }

        #endregion
        
        #region METHODS

        public string Greeting()
        {
            string greeting;

            switch (_attitude)
            {
                case EmotionalState.happy:
                    greeting = $"Hello, my name is {_name} and I have never felt this great before!";
                    break;

                case EmotionalState.sad:
                    greeting = $"Hey, people call me {_name}  and my friend just broke my heart.";
                    break;

                case EmotionalState.angry:
                    greeting = $"I'm {_name}, and stay the hell away from me!";
                    break;

                case EmotionalState.bored:
                    greeting = $"I don't know what to do at {_age} years old. I just cant seem to find anything to do.";
                    break;

                case EmotionalState.content:
                    greeting = $"Hey there, I'm {_name}. Everything is going to plan today!";
                    break;

                case EmotionalState.sleepy:
                    greeting = $"Who knew I'd be this tired at {_age} years old.";
                    break;

                default:
                    greeting = $"Hello, my name is {_name}.";
                    break;
            }
                       
            return greeting;
        }

        public string TribeInfo()
        {
            string tribeInfo;

            switch (_tribe)
            {
                case Tribe.Okishaba:
                    tribeInfo = "Welcome to the Okishaba Tribe, where there are no rules, and all we eat are potatoes!";
                    break;

                case Tribe.Rickastley:
                    tribeInfo = "Hello, and welcome to the Rickastley tribe! All we do is listen to 'Never gonna give you up' on repeat 24 hours a day! We are a slow tribe.";
                    break;

                case Tribe.Macdaddy:
                    tribeInfo = "F*#% BurgerKing!";
                    break;

                case Tribe.Referees:
                    tribeInfo = "Here within the Referee tribe, we make it a point to screw over the Lions!";
                    break;

                default:
                    tribeInfo = $"{_name} has not chose to be part of a tribe yet, {_name} believes in the tribe of life";
                    break;
            }

            return tribeInfo;
        }

        public string Activeness()
        {
            string activeness = Console.ReadLine();

            _active = false;

          if (activeness == "t")
          {
                _active = true;
          }
          else if (activeness != "t")
          {
                _active = false;
          }

            return activeness;
          
        }

        #endregion
    }
}
