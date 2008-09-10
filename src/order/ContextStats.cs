using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Pending,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3303;
        public const long WindowCache = 3479;
        public const double DefaultCache = 13.42;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count <= (count - count))
                {
                    count = ((count + 2) + entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
