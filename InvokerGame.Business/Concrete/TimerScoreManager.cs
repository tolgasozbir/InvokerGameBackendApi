using InvokerGame.Business.Abstract;
using InvokerGame.DataAccess.Abstract;
using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.Business.Concrete
{
    public class TimerScoreManager : ITimerScoreService
    {
        private ITimerScoreRepository _timerScoreRepository;

        public TimerScoreManager(ITimerScoreRepository timerScoreRepository)
        {
            _timerScoreRepository = timerScoreRepository;
        }

        public TimerScore AddNewScore(TimerScore timerScore)
        {
            return _timerScoreRepository.AddNewScore(timerScore);
        }

        public void DeleteScore(int id)
        {
            if (id<=0)
            {
                throw new Exception("id can not be less than 1");
            }

            _timerScoreRepository.DeleteScore(id);
        }

        public List<TimerScore> GetAllTimerScores()
        {
            return _timerScoreRepository.GetAllTimerScores();
        }
    }
}
