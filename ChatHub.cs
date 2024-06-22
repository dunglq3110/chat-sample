using chat_sample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using chat_sample.Dtos.Message;
namespace chat_sample
{
    public class ChatHub : Hub
    {
        
        public async Task SendMessageToAll(string user, string message, [FromServices] IMessageService messageService)
        {
            var usermessage = await messageService.InsertMessage(new MessageSendRequest(user, message));
            await Clients.All.SendAsync("ReceiveMessage", usermessage.Username, usermessage.Content);
            
        }

    }
}
