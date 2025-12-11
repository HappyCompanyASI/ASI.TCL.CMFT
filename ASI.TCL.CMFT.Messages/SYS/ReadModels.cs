namespace ASI.TCL.CMFT.Messages.SYS
{
    public static class ReadModels
    {
        public class Role
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string AuthorityList { get; set; }
        }

        public class User
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description{ get; set; }
            public Guid BelongRoleId { get; set; }
        }
    }
}
