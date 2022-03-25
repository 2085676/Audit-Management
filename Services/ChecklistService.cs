using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;
using AuditChecklistModule.Repository;

namespace AuditChecklistModule.Services
{
    public class ChecklistService : IChecklistService
    {
        private IChecklistRepo checklistRepoObj;
        private log4net.ILog log4netval;

        public ChecklistService(IChecklistRepo checklistRepoObj)
        {
            log4netval = log4net.LogManager.GetLogger(typeof(ChecklistService));
            this.checklistRepoObj = checklistRepoObj;
        }

        public List<AuditQuestions> GetQuestionList(string auditType)
        {
            log4netval.Info("Http GET request called" + nameof(ChecklistService));
            List<AuditQuestions> auditQuestionList = new List<AuditQuestions>();
            auditQuestionList = checklistRepoObj.GetQuestions(auditType);
            return auditQuestionList;
        }
    }
}
