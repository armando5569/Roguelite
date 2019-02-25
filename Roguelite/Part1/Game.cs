using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Game
    {
        protected int _level;
        protected int _gold;
        protected Character _player;
        protected Character _enemy;

        public Game(int level, int gold, Character player, Character enemy)
        {
            _level = level;
            _gold = gold;
            _player = player;
            _enemy = enemy;
        }

        public static Game LoadGame(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var binary = new BinaryFormatter();
                Game game = (Game)binary.Deserialize(stream);
                return game;
            }
        }
        public static void SaveGame(string path, Game g)
        {
            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                var binary = new BinaryFormatter();
                binary.Serialize(stream,g);
                stream.Flush();
                
            }
        }

        public int Level { get { return _level; } set { _level = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public Character Player { get { return _player; } set { _player = value; } }
        public Character Enemy { get { return _enemy; } set { _enemy = value; } }
    }
}
