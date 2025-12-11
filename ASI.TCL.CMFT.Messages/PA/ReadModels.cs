namespace ASI.TCL.CMFT.Messages.PA
{
    public static class ReadModels
    {
        public class VoiceGroup
        {
            public Guid Id { get; set; }
            public string GroupName { get; set; }
        }
        public class PreRecordVoice
        {
            public string Id { get; set; }
            public string VoiceName { get; set; }
            public string VoiceContent { get; set; }
            public bool IsIncludeCHN { get; set; }
            public bool IsIncludeTWN { get; set; }
            public bool IsIncludeHAKKA { get; set; }
            public bool IsIncludeENG { get; set; }
            public Guid BelongGroupId { get; set; }
        }
    }
}