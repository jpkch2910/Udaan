using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Udaan.Model;
using Udaan.Repository;

namespace Udaan.Controllers
{
    [ApiController]
    
    public class QuizController : ControllerBase
    {
        public IQuizRepository quizRepository;

        public QuizController(IQuizRepository repository)
        {
            quizRepository = repository;
        }

        [HttpGet]
        [Route("api/quiz/{quiz_id:int}")]
        public IActionResult GetQuiz(int quiz_id)
        {
            try
            {
                Quiz quiz = quizRepository.GetQuiz(quiz_id);
                if (quiz == null)
                {
                    return NotFound();
                }
                return Ok(quiz);
            }
            catch
            {
                return BadRequest(new { status = "failure", reason = "Failure" });
            }
        }
        [HttpPost]
        [Route("api/quiz")]
        public IActionResult CreateQuiz([System.Web.Http.FromBody] Quiz quiz)
        {
            quiz = quizRepository.CreateQuize(quiz);
            if (quiz == null)
            {
                return BadRequest(new { status = "failure", reason = "Invalid data" });
            }
            return Ok(quiz);
        }

        [HttpGet]
        [Route("api/questions/{question_Id:int}")]
        public IActionResult Getquestion(int question_Id)
        {
            try
            {
                Question question = quizRepository.GetQuestion(question_Id);
                if (question == null)
                {
                    return NotFound();
                }
                return Ok(question);
            }
            catch
            {
                return BadRequest(new { status = "failure", reason = "Failure" });
            }
        }
        [HttpPost]
        [Route("api/questions")]
        public IActionResult CreateQuestion([System.Web.Http.FromBody] Question question)
        {

            question = quizRepository.CreateQuestion(question);
            if (question == null)
            {
                return BadRequest(new { status = "failure", reason = "Invalid data" });
            }
            return Ok(question);
        }

        [HttpGet]
        [Route("api/quiz-questions/{quiz_id:int}")]
        public IActionResult GetAllQuestion(int quiz_id)
        {
            List<Question> questions = quizRepository.GetAllQuestion(quiz_id);
            if (questions == null || questions.Count == 0)
            {
                return NotFound();
            }
            return Ok(questions);
        }



    }
}
