using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;
/*
Internal
•	Have all Change requests followed SDLC before PROD move?
•	Have all Change requests been approved by the application owner?
•	Are all artifacts like CR document, Unit test cases available?
•	Is the SIT and UAT sign-off available?
•	Is data deletion from the system done with application owner approval?
SOX
•	Have all Change requests followed SDLC before PROD move?
•	Have all Change requests been approved by the application owner?
•	For a major change, was there a database backup taken before and after PROD move?
•	Has the application owner approval obtained while adding a user to the system?
•	Is data deletion from the system done with application owner approval?
 */

namespace AuditChecklistModule.Repository
{
    public class ChecklistRepo : IChecklistRepo
    {
        readonly log4net.ILog log4netval = log4net.LogManager.GetLogger(typeof(ChecklistRepo));
        const string filePath = "AllQuestions.txt";
        
        public List<AuditQuestions> GetQuestions(string auditType)
        {
            log4netval.Info("Log from " + nameof(ChecklistRepo));

            try
            {
                /*
                //use text file "AllQuestions.txt" to read all the audit questions

                StreamReader sr = new StreamReader(filePath);
                string[] questionData;
                List<AuditQuestions> questionList = new List<AuditQuestions>();
                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine();
                    questionData = str.Split(";");
                    int _QuestionNo = Convert.ToInt32(questionData[0]);
                    string _AuditCategory = questionData[1];
                    string _Question = questionData[2];
                    if (_AuditCategory.Contains(auditType))
                        questionList.Add(new AuditQuestions
                        {
                            QuestionNo = _QuestionNo,
                            AuditCategory = _AuditCategory,
                            Question = _Question
                        });
                }
                */
                var questions = DataHelper.AllQuestions.Where(t => t.AuditCategory == auditType);

                return questions.ToList();
            }
            catch (Exception e)
            {
                log4netval.Error("Found Exception " + e.Message + nameof(ChecklistRepo));
                return null;
            }
        }
    }
}
