using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.DataAccess.Abstract
{
    public interface ITimerScoreRepository
    {
        List<TimerScore> GetAllTimerScores();

        TimerScore AddNewScore(TimerScore timerScore);

        void DeleteScore(int id);
    }
}
