using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;
namespace AuditChecklistModule
{
    public class DataHelper
    {

        public static List<AuditQuestions> AllQuestions = new List<AuditQuestions>()
         {
            new AuditQuestions
            {
                QuestionNo=1,
                AuditCategory="Internal",
                Question="Have all Change requests followed SDLC before PROD move?"
            },
            new AuditQuestions
            {
                QuestionNo=2,
                AuditCategory="Internal",
                Question="Have all Change requests been approved by the application owner?"
            },
            new AuditQuestions
            {
                QuestionNo=3,
                AuditCategory="Internal",
                Question="Are all artifacts like CR document, Unit test cases available?"
            },
            new AuditQuestions
            {
                QuestionNo=4,
                AuditCategory="Internal",
                Question="Is the SIT and UAT sign-off available?"
            },
            new AuditQuestions
            {
                QuestionNo=5,
                AuditCategory="Internal",
                Question="Is data deletion from the system done with application owner approval?"
            },
                new AuditQuestions
            {
                QuestionNo=6,
                AuditCategory="SOX",
                Question="Have all Change requests followed SDLC before PROD move?"
            },
            new AuditQuestions
            {
                QuestionNo=7,
                AuditCategory="SOX",
                Question="Have all Change requests been approved by the application owner?"
            },
            new AuditQuestions
            {
                QuestionNo=8,
                AuditCategory="SOX",
                Question="For a major change, was there a database backup taken before and after PROD move?"
            },
            new AuditQuestions
            {
                QuestionNo=9,
                AuditCategory="SOX",
                Question="Has the application owner approval obtained while adding a user to the system?"
            },
            new AuditQuestions
            {
                QuestionNo=10,
                AuditCategory="SOX",
                Question="Is data deletion from the system done with application owner approval?"
            }
        };
    }
}