using InvokerGame.Business.Abstract;
using InvokerGame.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvokerGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private IScoreService _scoreService;

        public ScoresController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpGet("timer")]
        public List<TimerScore> GetAllTimerScores()
        {
            return _scoreService.GetAllTimerScores();
        }

        [HttpGet("challenger")]
        public List<ChallengerScore> GetAllChallengerScores()
        {
            return _scoreService.GetAllChallengerScores();
        }

        [HttpPost("timer")]
        public TimerScore AddTimerScore([FromBody] TimerScore timerScore)
        {
            return _scoreService.AddTimerScore(timerScore);
        }

        [HttpPost("challenger")]
        public ChallengerScore AddChallengerScore([FromBody] ChallengerScore challengerScore)
        {
            return _scoreService.AddChallengerScore(challengerScore);
        }

        //[HttpDelete("{id}")]
        //public void DeleteScore(int id) 
        //{ 
        //    _timerScoreService.DeleteScore(id);
        //}

    }
}
