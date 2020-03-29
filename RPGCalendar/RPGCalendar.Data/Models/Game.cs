using RPGCalendar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGCalendar.Data.Models
{
    public class Game : FingerPrintEntityBase
    {
        public string Title { get; set; }
        public User GameMaster { get; set; }
        public List<User> Players { get; set; }

    }
}
