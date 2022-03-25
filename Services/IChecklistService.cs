using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;

namespace AuditChecklistModule.Services
{
    public interface IChecklistService
    {
        public List<AuditQuestions> GetQuestionList(string auditType);
    }
}
