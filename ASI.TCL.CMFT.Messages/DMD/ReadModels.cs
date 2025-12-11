namespace ASI.TCL.CMFT.Messages.DMD
{
    public static class ReadModels
    {
        public class MessageGroup
        {
            public Guid Id { get; set; }
            public string GroupName { get; set; }
        }


        public class PreRecordMessage
        {
            public Guid Id { get; set; }
            public string MessageName { get; set; }
            public string MessageContent { get; set; }
            public Guid BelongGroupId { get; set; }
            public bool IsUseDU { get; set; }
        }
    }
}