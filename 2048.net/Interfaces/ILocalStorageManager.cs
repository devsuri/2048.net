﻿using System;

namespace DCCC.Interfaces
{
    public interface ILocalStorageManager
    {
        uint GetBestScore();
        void SetBestScore(uint score);
        IGameState GetGameState();
        void SetGameState(IGameState gameState);
        void ClearGameState();
        void ClearAllData();
    }

    public class DefaultLocalStorageManager : ILocalStorageManager
    {
        public void ClearAllData()
        {
        }

        public void ClearGameState()
        {
        }

        public uint GetBestScore()
        {
            return 0;
        }

        public IGameState GetGameState()
        {
            return null;
        }

        public void SetBestScore(uint score)
        {
        }

        public void SetGameState(IGameState gameState)
        {
        }
    }

    public interface IGameState
    {
        GameGrid Grid { get; set; }
        uint Score { get; set; }
        bool Over { get; set; }
        bool Won { get; set; }
        bool KeepPlaying { get; set; }
    }
}
