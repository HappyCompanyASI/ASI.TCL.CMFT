namespace ASI.TCL.CMFT.Messages.SYS
{
    public static class PermissionKey
    {
        public const string CanUseRegistration = nameof(CanUseRegistration);

        public const string CanViewRole = nameof(CanViewRole);
        public const string CanUpdateRole = nameof(CanUpdateRole);
        public const string CanDeleteRole = nameof(CanDeleteRole);

        public const string CanViewUser = nameof(CanViewUser);
        public const string CanUpdateUser = nameof(CanUpdateUser);
        public const string CanDeleteUser = nameof(CanDeleteUser);

        public const string CanViewReports = nameof(CanViewReports);
        public const string CanOutputReports = nameof(CanOutputReports);

        public const string CanCheckFastTrack = nameof(CanCheckFastTrack);
        public const string CanCheckLoungeEntry = nameof(CanCheckLoungeEntry);

        public static List<string> GetAdminstratorPermissions() =>
        [
            CanUseRegistration,
            CanViewRole,
            CanUpdateRole,
            CanViewUser,
            CanUpdateUser,
            CanViewReports,
            CanOutputReports,
            CanCheckFastTrack,
            CanCheckLoungeEntry
        ];


        public static List<string> GetMemberPermissions() =>
        [
            CanUseRegistration,
        ];
    }
}