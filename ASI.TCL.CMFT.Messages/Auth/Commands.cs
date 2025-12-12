namespace ASI.TCL.CMFT.Messages.Auth
{
    public static class Commands
    {
        /// <summary>
        /// 使用者登入
        /// </summary>
        public class LoginCommand
        {
            public string Account { get; set; }
            public string Password { get; set; }
        }
        /// <summary>
        /// 使用者登出
        /// </summary>
        public class LogoutCommand
        {
        }
    }
}
