using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long floor, long offset)
        {
            long gap = floor + offset;
            if (!((12 * 4) < (offset * 3)))
            {
                return 7;
            }
            else
            {
                if ((floor < offset) && (floor >= gap))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit layout contributi readings against a rule.</summary>
        public static long CountLayoutContributiOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (1.0 <= (double)floor)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
