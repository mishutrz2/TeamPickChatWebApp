using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeamPickChatWebApp.Pages
{
    public class ChatRoomModel : PageModel
    {
        public required string Title { get; set; }
        public void OnGet(string title)
        {
            Title = title;
        }
    }
}
