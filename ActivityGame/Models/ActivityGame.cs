using System;

namespace ActivityGame {
    public class ActivityGame {
        public int Meal;
        public int Happiness;
        public int Energy;
        public int Fullness;
        public string Log;
        public string Img;

        public ActivityGame () {
            Meal = 3;
            Happiness = 20;
            Energy = 50;
            Fullness = 20;
            Log = "You have found a wild Dojodachi!";
            Img = "https://i.pinimg.com/originals/54/7f/22/547f2244bc986bb4e206c456a3f453bb.jpg";

        }

        public void EatMeal () {
            Random rand = new Random ();
            int food = rand.Next (5, 10);
            Fullness += food;
            int num = rand.Next (1, 5);
            if (num == 1) {
                Meal -= 1;
                Log = "Your Dojodachi did not like the food. Furious it is!";
                Img = "https://i.pinimg.com/originals/a8/db/c3/a8dbc3bee511c1ba0f856bf4026b13fb.jpg";
            } else {
                Fullness += food;
                Meal -= 1;
                Log = "Your Dojodatchi was famished! It has gained much fullness from this meal";
                Img = "https://i.imgur.com/SqcRMd8.jpg";
            }
        }
        public void Playing () {
            Random rand = new Random ();
            int play = rand.Next (5, 10);
            int num = rand.Next (1, 5);
            if (num == 1) {
                Log = "Your Dojodatchi has NOT had fun. Unpleased it is.";
                Img = "https://i.pinimg.com/originals/46/0b/fa/460bfa92d93a008c536cc4d9e1d0791c.jpg";
                Energy -= 5;
            } else {
                Log = "Your Dojodatchi has had fun. Dojodatchi is getting sleepy";
                Img = "https://www.pngitem.com/pimgs/m/511-5119707_cute-fox-girl-anime-hd-png-download.png";
                Happiness += play;
                Energy -= 5;
            }
        }
        public string serialize () {
            string output = "{";
            output += $"\"Energy\": {Energy},";
            output += $"\"Happiness\": {Happiness},";
            output += $"\"Meal\": {Meal},";
            output += $"\"Fullness\": {Fullness}";
            return output + "}";
        }
        public void Working () {
            Random rand = new Random ();
            int work = rand.Next (5, 10);
            Log = "Your Dojodatchi is always ready for work.";
            Img = "https://img.pngio.com/kitsune-fantasy-warrior-roleplay-wiki-fandom-powered-by-wikia-anime-girl-warrior-png-1700_3000.png";
            Energy -= 5;
            Meal += work;
        }
        public void Sleeping () {
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
            Img = "https://mocah.org/uploads/posts/4548603-anime-girls-fox-girl-tou-no-shita-no-exercitus-rico-terra-visual-novel.png";
        }
        public void Restart () {
            Meal = 3;
            Happiness = 20;
            Energy = 50;
            Fullness = 20;
            Log = "You have found a wild Dojodachi!";
            Img = "https://i.pinimg.com/originals/54/7f/22/547f2244bc986bb4e206c456a3f453bb.jpg";

        }
        public bool HasWon () {
            if (Fullness >= 100 && Happiness >= 100 && Energy >= 100) {
                Log = "Congratulations Dojodatchi. You have escaped back into the wild.\nNever again will you be confined";
                Img = "https://mocah.org/uploads/posts/4569042-original-characters-fox-animals-moon-eagle.jpg";
                return true;
            } else {
                return false;
            }
        }
        public bool HasDied () {
            if (Energy <= 0 || Happiness <= 0) {
                Log = "Rest in peace Dojodatchi. Please do not haunt those of us who remain.";
                Img = "https://pm1.narvii.com/6432/34e7dc2c0aaae61035396c7975a2d55a4b734400_hq.jpg";
                return true;
            } else {
                return false;
            }
        }
    }
}