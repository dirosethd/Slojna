using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Setting
{
    public sealed class GameSettings
    {
        private static GameSettings? _instance;
        private static readonly object _lock = new object();

        public string GameName { get; set; } = "RPG SYSTEM";
        public string Difficulty { get; set; } = "Normal";
        public int MaxLevel { get; set; } = 100;
        public int SoundVolume { get; set; } = 50;

        private GameSettings() { }

        public static GameSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new GameSettings();
                    }
                }
                return _instance;
            }
        }
    }
}
