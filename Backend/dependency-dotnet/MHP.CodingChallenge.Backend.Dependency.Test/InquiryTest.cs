using Xunit;
using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using Microsoft.Extensions.DependencyInjection;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using MHP.CodingChallenge.Backend.Dependency;
using Moq;
using MHP.CodingChallenge.Backend.Dependency.Inquiry.Interface;
using MHP.CodingChallenge.Backend.Dependency.Middleware;

namespace MHP.CodingChallenge.Backend.Dependency.Test
{
    public class InquiryTest
    {
        private InquiryController controller;

        [Fact]
        public void TestInquiryHandlers()
        {
            

            // given
            Inquiry.Inquiry inquiry = new Inquiry.Inquiry();
            inquiry.Username = "TestUser";
            inquiry.Recipient = "service@example.com";
            inquiry.Text = "Can I haz cheezburger?";

            // room for potential additional test setup

            //New Mock -> Interface
            var mockEmailHander = new Mock<IEmailHandler>();
            var mockPushNotificationHandler = new Mock<INotificationHandler>();


            //Old Mock -> Static binding
            //var mockEmailHander = new Mock<CentralEmailHandler>();
            // var mockPushNotificationHandler = new Mock<PushNotificationHandler>();

            var services = new ServiceCollection()
                .AddLogging()
                .AddSingleton<InquiryService>()
                .AddSingleton(mockEmailHander.Object)
                .AddSingleton(mockPushNotificationHandler.Object);


            var inquiryService = services
                .BuildServiceProvider()
                .GetRequiredService<InquiryService>();

            //###############
           // controller = new InquiryController(null, mockEmailHander.Object, mockPushNotificationHandler.Object);

            //mockEmailHander.Setup(e => e.SendEmail(inquiry));
            //mockPushNotificationHandler.Setup(e => e.SendNotification(inquiry));
            //###############

            // when
            inquiryService.Create(inquiry);



            // then
            mockEmailHander.Verify(e => e.SendEmail(inquiry), Times.Once());
            mockPushNotificationHandler.Verify(e => e.SendNotification(inquiry), Times.Once());
        }
    }
}
