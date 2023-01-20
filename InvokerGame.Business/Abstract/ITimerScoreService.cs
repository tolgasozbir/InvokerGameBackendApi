using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.Business.Abstract
{
    public interface ITimerScoreService
    {
        List<TimerScore> GetAllTimerScores();

        TimerScore AddNewScore(TimerScore timerScore);

        void DeleteScore(int id);
    }
}
