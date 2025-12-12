namespace ASI.TCL.CMFT.Messages.SYS
{
    public static class Commands
    {

        public class CreateRole
        {
        }

        public class UpdateRole
        {
        }

        public class DeleteRole
        {
        }


        /// <summary>
        /// 創建系統使用者
        /// </summary>
        public class CreateUser
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Guid BelongRoleId { get; set; }
        }
        /// <summary>
        /// 編輯使用者名稱
        /// </summary>
        public class ChangeUserName
        {
            public string Id { get; set; }
            public string NewName { get; set; }
        }
        /// <summary>
        /// 編輯使用者描述
        /// </summary>
        public class ChangeUserDescription
        {
            public string Id { get; set; }
            public string NewDescription { get; set; }
        }
        /// <summary>
        /// 編輯使用者所屬群組
        /// </summary>
        public class ChangeUserBelongRole
        {
            public string Id { get; set; }
            public Guid BelongRoleId { get; set; }
        }

        /// <summary>
        /// 編輯使用者
        /// </summary>
        public class UpdateUserDetails
        {
            public string Id { get; set; }
            public string NewName { get; set; }
            public string NewDescription { get; set; }
            public Guid BelongRoleId { get; set; }
        }

        /// <summary>
        /// 刪除使用者
        /// </summary>
        public class DeleteUser
        {
            public string Id { get; set; }
        }
    }
}