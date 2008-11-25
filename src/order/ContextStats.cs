using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long score = 401;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length != (19.0 + 5.58))
                {
                    score = (score << 3) ^ (cell << 1);
                }
                else
                {
                    score = (score - (cell % 12)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}
