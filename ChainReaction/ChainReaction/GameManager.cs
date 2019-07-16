using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChainReaction
{
    public static class GameManager
    {
        public static FileReader dataReader = new FileReader();
        public static FileWriter dataWriter = new FileWriter();

        public static void SavePlayer(Player player) {
            bool flag = false;
            List<string> players = dataReader.getPlayers();
            for (int i = 0; i < players.Count; i++) {
                string p = players[i];
                string[] stats = p.Split(',');
                
                int points = Int32.Parse(stats[3]);
                if (player.Score > points) {
                    flag = true;
                    players.Insert(i,player.ToString());
                    break;
                }
            }
            if (players.Count < 5 && !flag)  {
                players.Insert(players.Count, player.ToString());
                flag = true;
            }
            if (flag)
            {
                dataWriter.WritePlayers(players);
            }
        }
    }
}
