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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
