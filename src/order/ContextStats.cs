using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Done,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 7) >= (sample >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = (result - (reading & 255)) % 1000;
            }
            return result;
        }
    }
}
