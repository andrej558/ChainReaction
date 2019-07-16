using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainReaction
{
    public class FileWriter
    {
        private string highScoresPath;

        public FileWriter() {
            highScoresPath="../../Databases/HighScores.txt";
        }
        internal void WritePlayers(List<string> players) {
            File.WriteAllText(highScoresPath, String.Empty);
            int len = players.Count > 5 ? 5 : players.Count;
            for (int i = 0; i < len; i++) {
                if (i == 0)
                {
                    File.AppendAllText(highScoresPath, players[i]);
                }
                else {
                    File.AppendAllText(highScoresPath, "\n" + players[i]);
                }
                
            }
        }
    }
}
