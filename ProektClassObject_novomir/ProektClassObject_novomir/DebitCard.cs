using System;
using System.Collections.Generic;
using System.Text;

namespace ProektClassObject_novomir
{
    internal class DebitCard
    {
        private long id;
        private int passcode;
        private string names;
        private float money;

        int salary;
       
        public long Id { 
            get { 
                return id;
            }
            set {
                if (value > 0 && value < 9999999999999999) { id = value; } else { Console.WriteLine("invalid ID"); }
            } 
        }
        public int Passcode { get { return passcode; } set { if (value > 0 && value < 9999) { passcode = value; } else { Console.WriteLine("invalid passcode"); } } }
        public DebitCard(long id, int passcode, string names, float money, int salary)
        {
            Id = id;
            Passcode = passcode;
            this.names = names;
            this.money = money;
            this.salary = salary;
        }

        public float PayDay() { money += salary;return money; }
        public void Info()
        {
            Console.WriteLine($"id:{id},names:{names},money:{money},salary:{salary}");
        }
    }

 }
