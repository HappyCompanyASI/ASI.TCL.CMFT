namespace ASI.TCL.CMFT.Messages.DMD
{
    public static class Commands
    {
        /// <summary>
        /// 創建訊息群組
        /// </summary>
        public class CreateGroup
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

        /// <summary>
        /// 改變訊息群組名稱
        /// </summary>
        public class ChangeGroupName
        {
            public Guid Id { get; set; }
            public string NewName { get; set; }
        }

        /// <summary>
        /// 刪除訊息群組，並將此群組的所有訊息刪除
        /// </summary>
        public class DeleteGroupWithMessages
        {
            public Guid Id { get; set; }
        }

        /// <summary>
        /// 刪除訊息群組，並將此群組的所有訊息的所屬群組設為Null
        /// </summary>
        public class DeleteGroupAndDetachMessages
        {
            public Guid Id { get; set; }
        }

        /// <summary>
        /// 創建訊息
        /// </summary>
        public class CreateMessage
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Content { get; set; }
            public bool IsUseDu { get; set; }
            public Guid? BelongGroupId { get; set; }
        }

        /// <summary>
        /// 編輯訊息名稱
        /// </summary>
        public class ChangeMessageName
        {
            public Guid Id { get; set; }
            public string NewName { get; set; }
           
        }

        /// <summary>
        /// 編輯訊息內容
        /// </summary>
        public class ChangeMessageContent
        {
            public Guid Id { get; set; }
            public string NewContent { get; set; }

        }

        /// <summary>
        /// 編輯訊息DU
        /// </summary>
        
        public class ChangeMessageDUState
        {
            public Guid Id { get; set; }
            public bool NewDUState { get; set; }
        }

        /// <summary>
        /// 編輯訊息所屬群組
        /// </summary>
        public class ChangeMessageBelongGroup
        {
            public Guid Id { get; set; }
            public Guid? NewBelongGroupId { get; set; }
        }

        /// <summary>
        /// 編輯訊息
        /// </summary>
        public class UpdateMessageDetails
        {
            public Guid Id { get; set; }
            public string NewName { get; set; }
            public string NewContent { get; set; }
            public bool NewDUState { get; set; }
            public Guid? NewBelongGroupId { get; set; }
        }

        /// <summary>
        /// 刪除訊息
        /// </summary>
        public class DeleteMessage
        {
            public Guid Id { get; set; }
        }
    }
}