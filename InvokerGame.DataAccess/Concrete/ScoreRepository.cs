using InvokerGame.DataAccess.Abstract;
using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokerGame.DataAccess.Concrete
{
    public class ScoreRepository : IScoreRepository
    {
        public ChallengerScore AddChallengerScore(ChallengerScore challengerScore)
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                dbContext.ChallengerScores.Add(challengerScore);
                dbContext.SaveChanges();
                return challengerScore;
            }
        }

        public TimerScore AddTimerScore(TimerScore timerScore)
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                dbContext.TimerScores.Add(timerScore);
                dbContext.SaveChanges();
                return timerScore;
            }
        }

        public List<ChallengerScore> GetAllChallengerScores()
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                return dbContext.ChallengerScores.OrderByDescending(e => e.Score).ToList();
            }
        }

        public List<TimerScore> GetAllTimerScores()
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                return dbContext.TimerScores.OrderByDescending(e => e.Score).ToList();
            }
        }

        //public void DeleteScore(int id)
        //{
        //    using (var dbContext = new InvokerGameDbContext())
        //    {
        //        var deletedScore = dbContext.TimerScores.Find(id);

        //        if (deletedScore != null)
        //        {
        //            dbContext.TimerScores.Remove(deletedScore);
        //            dbContext.SaveChanges();
        //        }
        //    }
        //}
    }
}
