using MHP.CodingChallenge.Backend.Dependency.Inquiry.Interface;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Dependency.Middleware
{
    public class CentralNotificationHandler : INotificationHandler
    {

        private INotificationHandler _hndlPush;

        public CentralNotificationHandler(INotificationHandler hndlPush)
        {
            _hndlPush = hndlPush;
        }

        public void SendNotification(Inquiry.Inquiry inquiry)
        {
            _hndlPush.SendNotification(inquiry);
        }
    }
}
