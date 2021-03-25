using ChallengePasswordItau.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengePasswordItau.Helpers
{
    public static class ReturnHelper
    {
        public static JsonResult Try(bool? success, string message)
        {
            ReturnModel returnModel = new ReturnModel();
            AnswersModel Answers = new AnswersModel();            

            if (success == null)
            {
                Answers = new AnswersModel()
                {
                    Message = message,
                    Status = 0
                };
                
                return new JsonResult(Answers);                               
            }
            else
            {
                returnModel.returnResult = success;

                return new JsonResult(returnModel);
            }
            
        }

    }    
}
