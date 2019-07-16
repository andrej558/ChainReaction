using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainReaction
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; private set; }
        public DateTime startedPlaying { get; set; }
        public int elapsedTime { get; set; }

        public Player(string name,DateTime timePlayed, int score, int elapseTime)
        {
            Name = name;
            startedPlaying = timePlayed;
            Score = score;  //initial
            elapsedTime = elapseTime;
        }
        public void addPoints(int points) {
            Score+=points;
        }
        public void addSecond() {
            elapsedTime++;
        } 
        public override string ToString()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTime);
            string s = startedPlaying.Month + "/" + startedPlaying.Day + "/" + startedPlaying.Year +
                " " + startedPlaying.Hour + ":" + startedPlaying.Minute;
            return Name + "," + s + "," + timeSpan.Minutes+":"+timeSpan.Seconds + "," + Score;
        }
    }
}
