using System;
using MHP.CodingChallenge.Backend.Dependency.Inquiry.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Logging;

namespace MHP.CodingChallenge.Backend.Dependency.Inquiry
{
    public class InquiryService
    {
        private readonly IEmailHandler _EmailHandler;
        private readonly INotificationHandler _NotificationHandler;

        public InquiryService(IEmailHandler EmailHandler, INotificationHandler NotificationHandler)
        {
            _EmailHandler = EmailHandler;
            _NotificationHandler = NotificationHandler;
        }

        public void Create(Inquiry inquiry)
        {
            Console.WriteLine(string.Format("User sent inquiry: {0}", inquiry.ToString()));
            _EmailHandler.SendEmail(inquiry);
            _NotificationHandler.SendNotification(inquiry);
        }



    }
}
