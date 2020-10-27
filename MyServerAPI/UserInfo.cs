using System;

namespace Server
{
    public class UserInfo
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public byte[] Avatar { get; set; }
    }
}