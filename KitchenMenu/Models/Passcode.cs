using System;

namespace KitchenMenu.Models
{
    public class Passcode
    {
        public string Value { get; set; }

        public Passcode()
        {
            string choices = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random r = new Random();
            for(int i=0; i<14; i++)
            {
                Value += choices[r.Next(choices.Length)];
            }
        }
    } 
}