using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
