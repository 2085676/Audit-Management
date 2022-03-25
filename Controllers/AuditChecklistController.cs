using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditChecklistModule.Models;
using AuditChecklistModule.Services;
using AuditChecklistModule.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AuditChecklistModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuditChecklistController : ControllerBase
    {
        private readonly log4net.ILog log4netval;
        private IChecklistService checklistServiceObj;

        public AuditChecklistController(IChecklistService checklistServiceObj)
        {
            log4netval = log4net.LogManager.GetLogger(typeof(AuditChecklistController));
            this.checklistServiceObj = checklistServiceObj;
        }
         
        [HttpGet]
        public IActionResult GetAuditCheckListQuestions(string auditType)
        {
            log4netval.Info("AuditChecklistController Http GET request called" + nameof(AuditChecklistController));

            if (string.IsNullOrEmpty(auditType))
                return BadRequest("Got Null or empty Input");
            else if ((auditType!="Internal")&&(auditType!="SOX"))
                return BadRequest("Unexpected Input: Expected 'Internal' or 'SOX'");
            else
            {
                try
                {
                    List<AuditQuestions> auditQuestionList = checklistServiceObj.GetQuestionList(auditType);
                    return Ok(auditQuestionList);
                }
                catch (Exception e)
                {
                    log4netval.Error("Found Exception: " + e.Message + nameof(AuditChecklistController));
                    return StatusCode(500);
                }
            }
        }
    }
}
