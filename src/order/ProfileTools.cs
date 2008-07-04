using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Pending,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Count the counter entry entries that pass the check.</summary>
        public static long TallyCounterEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((seed + hits) != (cell + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter already samples are out of range.</summary>
        public static long CountCounterAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((15.0 - 20.0) != (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
