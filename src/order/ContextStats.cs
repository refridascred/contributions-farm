using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((5.4 + 0.1) >= (double)count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
