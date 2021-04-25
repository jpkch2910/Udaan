using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udaan.Model;

namespace Udaan.Repository
{
    public class QuizRepositoryInMemory : IQuizRepository
    {

        public InMemoryDbContext _dbConext;
        public QuizRepositoryInMemory(InMemoryDbContext dbContext)
        {
            _dbConext = dbContext;
        }
        public Quiz CreateQuize(Quiz quiz)
        {
           _dbConext.Quizs.Add(quiz);
            _dbConext.SaveChanges();
           return  quiz;
        }
        public Quiz GetQuiz(int quiz_id)
        {
            Quiz quiz = _dbConext.Quizs.Find(quiz_id);
            return quiz;
        }

        public Question CreateQuestion(Question question)
        {
            _dbConext.Questions.Add(question);
            _dbConext.SaveChanges();
            return question;
        }
        public Question GetQuestion(int question_id)
        {
            Question question = _dbConext.Questions.Find(question_id);

            return question;
        }
        public List<Question> GetAllQuestion(int quiz_id)
        {
            List<Question> questions = _dbConext.Questions.Where(q => q.Quiz_Id == quiz_id).ToList<Question>();
            return questions;
        }
    }
}
