using InvokerGame.DataAccess.Abstract;
using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvokerGame.DataAccess.Concrete
{
    public class TimerScoreRepository : ITimerScoreRepository
    {
        public TimerScore AddNewScore(TimerScore timerScore)
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                dbContext.TimerScores.Add(timerScore);
                dbContext.SaveChanges();
                return timerScore;
            }
        }

        public void DeleteScore(int id)
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                var deletedScore = dbContext.TimerScores.Find(id);

                if (deletedScore != null)
                {
                    dbContext.TimerScores.Remove(deletedScore);
                    dbContext.SaveChanges();
                }
            }
        }

        public List<TimerScore> GetAllTimerScores()
        {
            using (var dbContext = new InvokerGameDbContext())
            {
                return dbContext.TimerScores.ToList();
            }
        }
    }
}
