using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "legacy-1";
        public const long BurstDepth = 5901;
        public const string LimitGraph = "legacy-v2";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + floor) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support metric readings.</summary>
        public static long MatchSupportMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
