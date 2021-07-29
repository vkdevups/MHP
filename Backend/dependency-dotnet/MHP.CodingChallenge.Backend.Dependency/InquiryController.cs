using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using MHP.CodingChallenge.Backend.Dependency.Inquiry.Interface;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Dependency
{
    [Route("api/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase
    {

        private InquiryService _srvcInquiry;

        public InquiryController(InquiryService srvcInquiry)
        {
            _srvcInquiry = srvcInquiry;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpPost]
        public HttpResponseMessage Post(Inquiry.Inquiry _inquiry)
        {
            HttpResponseMessage response;

            if (!ModelState.IsValid)
            {
                response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }



            //1. Create 
            _srvcInquiry.Create(_inquiry);

              response = new HttpResponseMessage(HttpStatusCode.OK);
            return response;
        }

    }
}
