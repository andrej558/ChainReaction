using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainReaction
{
    public class FileReader
    {
        private string highScoresPath;

        public FileReader() {
            highScoresPath = "../../Databases/HighScores.txt";
        }
        public List<string> getPlayers() {
            string[] players = File.ReadAllLines(highScoresPath).Take(5).ToArray();
            return new List<string>(players);
            
        }
    }
}
