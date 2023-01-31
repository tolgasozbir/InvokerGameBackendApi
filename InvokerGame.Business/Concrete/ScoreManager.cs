using InvokerGame.Business.Abstract;
using InvokerGame.DataAccess.Abstract;
using InvokerGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerGame.Business.Concrete
{
    public class ScoreManager : IScoreService
    {
        private IScoreRepository _scoreRepository;

        public ScoreManager(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }


        //business codes
        public ChallengerScore AddChallengerScore(ChallengerScore challengerScore)
        {
            return _scoreRepository.AddChallengerScore(challengerScore);
        }

        public TimerScore AddTimerScore(TimerScore timerScore)
        {
            return _scoreRepository.AddTimerScore(timerScore);
        }

        public List<ChallengerScore> GetAllChallengerScores()
        {
            return _scoreRepository.GetAllChallengerScores();
        }

        public List<TimerScore> GetAllTimerScores()
        {
            return _scoreRepository.GetAllTimerScores();
        }

        //public void DeleteScore(int id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new Exception("id can not be less than 1");
        //    }

        //    _timerScoreRepository.DeleteScore(id);
        //}
    }
}
