using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;

namespace AuditChecklistModule.Repository
{
    public interface IChecklistRepo
    {
        public List<AuditQuestions> GetQuestions(string auditType);
    }
}
