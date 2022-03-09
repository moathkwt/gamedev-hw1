using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = "arrow";

            int health = 100;


            int damaged(int downHealth)
            {
                return health - downHealth;
            }
            int characterHealth = damaged(20);
            Console.WriteLine(" damaged health : " + characterHealth);


            int boost(int upHealth)
            {
                return characterHealth + upHealth;
            }
            int boostHealth = boost(10);


            Console.WriteLine(" boosted health : " + boostHealth);

            string[] HealthArray = { "80", "90" };
            Console.WriteLine(HealthArray[1]);

            

            {
                if (characterHealth > boostHealth)
                {
                    Console.WriteLine(boostHealth + " is less than " + characterHealth);
                }
                else if (boostHealth > characterHealth)
                {
                    Console.WriteLine(characterHealth + " is less than " + boostHealth);
                }
                


            }
        }
    }
}
