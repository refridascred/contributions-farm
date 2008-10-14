using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2365;
        public const double SoftGraph = 9.86;
        public const string RetryGraph = "fallback-v2";
        public const long BatchGraph = 5534;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Pending,
            Queued,
            Active,
            Done,
        }
    }
}
