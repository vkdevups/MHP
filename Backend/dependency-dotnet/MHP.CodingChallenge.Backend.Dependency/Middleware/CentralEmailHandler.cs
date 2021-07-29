using MHP.CodingChallenge.Backend.Dependency.Inquiry.Interface;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Dependency.Middleware
{
    public class CentralEmailHandler : IEmailHandler
    {
        private IEmailHandler _hndlEmail;

        public CentralEmailHandler(IEmailHandler hndlEmail)
        {
            _hndlEmail = hndlEmail;
        }

        public  void SendEmail(Inquiry.Inquiry inquiry)
        {
            _hndlEmail.SendEmail(inquiry);
        }
    }

}
