using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistModule.Models
{
    public class AuditQuestions
    {
        public int QuestionNo { get; set; }
        public string AuditCategory { get; set; }
        public string Question { get; set; }
    }
}
