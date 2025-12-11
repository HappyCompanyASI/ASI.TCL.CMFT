namespace ASI.TCL.CMFT.Messages.PA
{
    public static class Commands
    {
        /// <summary>
        /// 創建語音群組
        /// </summary>
        public class CreateGroup
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

        /// <summary>
        /// 改變語音群組名稱
        /// </summary>
        public class ChangeGroupName
        {
            public Guid Id { get; set; }
            public string NewName { get; set; }
        }

        /// <summary>
        /// 刪除語音群組，並將此群組的所有語音的所屬群組設為Null
        /// </summary>
        public class DeleteGroupAndDetachVoices
        {
            public Guid Id { get; set; }
        }

        /// <summary>
        /// 編輯語音所屬群組
        /// </summary>
        public class ChangeVoiceBelongGroup
        {
            public string Id { get; set; }
            public Guid? NewBelongGroupId { get; set; }
        }
    }
}