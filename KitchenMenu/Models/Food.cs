using System;

namespace KitchenMenu.Models
{
    public class Food
    {
        public string Value { get; set; }

        public Food()
        {
            Random r = new Random();
            string[] proteins = new string[]{
                "Chicken",
                "Salmon",
                "Pork Belly",
                "Seal Blubber",
                "Tofu",
                "Sweetbreads",
                "Milk Steak"
            };
            string[] preperations = new string[]{
                "Sauteed",
                "Fried",
                "Baked",
                "Boiled",
                "Grilled",
                "Cedar Planked",
                "Steamed",
                "Microwaved",
                "Blackened",
                "Jerked",
                "Poached",
                "Scrambled"
            };
            Value += preperations[r.Next(preperations.Length)];
            Value += " ";
            Value += proteins[r.Next(proteins.Length)];
        }
    } 
}