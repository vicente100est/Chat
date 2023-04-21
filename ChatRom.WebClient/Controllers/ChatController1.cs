using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChatRom.WebClient.Controllers
{
    public class ChatController1 : Controller
    {
        public static Dictionary<int, string> Rooms =
            new Dictionary<int, string>()
            {
                {
                    1,
                    "Cervezas"
                },
                {
                    2,
                    "Programacion"
                },
                {
                    3,
                    "Futbol"
                }
            };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
