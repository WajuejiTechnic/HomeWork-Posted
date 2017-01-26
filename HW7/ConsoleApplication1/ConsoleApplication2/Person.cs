using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public Person(string name, int age, string gender)
        {
            this._name = name;
            this._age = age;
            this._gender = gender;
        }


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = "John";
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                if(value>=0 && value<=120)
                {
                    this._age = value;
                }
            }
        }

        public string Gender
        {
            get
            {
                return this._gender;
            }

            set
            {
                if (value == "Male" || value == "Female")
                {
                    this._gender = value;
                }
            }
        }

            public Tuple<string,int, string> GetAllInfo(string name, int age, string gender)
        {
            return new Tuple<string, int, string>("John", 65, "Male");

        }

        }
    }

