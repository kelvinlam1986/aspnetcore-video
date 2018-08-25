using AspNetCoreVideo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.ViewComponents
{
    public class Message : ViewComponent
    {
        private IMessageService _messageService;

        public Message(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _messageService.GetMessage();
            return View("Default", model);
        }
    }
}
