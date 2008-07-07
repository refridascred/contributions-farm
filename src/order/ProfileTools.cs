using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Queued,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5937;
        public const long MinMetric = 6723;
        public const string LimitMetric = "local-1";
        public const string StepRatio = "staging";

        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Idle,
            Draft,
            Active,
        }
    }
}
