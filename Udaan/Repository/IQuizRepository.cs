using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udaan.Model;

namespace Udaan.Repository
{
   public  interface IQuizRepository
    {
        public Quiz CreateQuize(Quiz quiz);
        public Quiz GetQuiz(int quiz_id);

        public Question CreateQuestion(Question question);
        public Question GetQuestion(int question_id);
        public List<Question> GetAllQuestion(int quiz_id);

    }
}
