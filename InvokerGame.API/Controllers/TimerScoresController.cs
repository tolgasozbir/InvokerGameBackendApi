using InvokerGame.Business.Abstract;
using InvokerGame.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvokerGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimerScoresController : ControllerBase
    {
        private ITimerScoreService _timerScoreService;

        public TimerScoresController(ITimerScoreService timerScoreService)
        {
            _timerScoreService = timerScoreService;
        }

        [HttpGet]
        public List<TimerScore> GetAllScores()
        {
            return _timerScoreService.GetAllTimerScores();
        }        
        
        [HttpPost]
        public TimerScore AddScore([FromBody] TimerScore timerScore)
        {
            return _timerScoreService.AddNewScore(timerScore);
        }

        [HttpDelete("{id}")]
        public void DeleteScore(int id) 
        { 
            _timerScoreService.DeleteScore(id);
        }

    }
}
