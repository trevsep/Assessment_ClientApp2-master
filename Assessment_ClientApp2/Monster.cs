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

        #region FIELDS

        private string _name;
        private int _age;
        private EmotionalState _attitude;

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

        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name, int age, EmotionalState attitude)
        {
            _name = name;
            _age = age;
            _attitude = attitude;
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

        #endregion
    }
}
