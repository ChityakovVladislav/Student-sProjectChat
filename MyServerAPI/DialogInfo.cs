using System;

namespace Server
{
    public class DialogInfo
    {
        public Guid DialogId { get; set; }
        public UserInfo user { get; set; }
        public string LastMessage { get; set; }

    }
}