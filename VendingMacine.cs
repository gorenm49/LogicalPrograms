using System;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        public void vending()
        {

            int [] notes = {1000, 500, 100, 50, 10, 5, 2, 1};
            int [] holdValue = new int [notes.Length];

            System.Console.WriteLine("Enter amount to Change for");
            int changeFor = int.Parse(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                if (changeFor / notes[i] > 0)
                {
                    holdValue[i] = changeFor / notes[i] ;   
                    changeFor -= notes[i] * holdValue[i];

                }
            }

            for (int i = 0; i < notes.Length; i++)
            {
                if (holdValue[i]!= 0)
                {
                    System.Console.WriteLine(notes[i]+" - "+holdValue[i]);
                }
            }
        }

    }
}