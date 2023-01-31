using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.DataAccess.Abstract
{
    public interface IScoreRepository
    {
        List<TimerScore> GetAllTimerScores();
        List<ChallengerScore> GetAllChallengerScores();

        TimerScore AddTimerScore(TimerScore timerScore);
        ChallengerScore AddChallengerScore(ChallengerScore challengerScore);

        //void DeleteScore(int id);
    }
}
