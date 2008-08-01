using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7114;
        public const double CacheDepth = 64.68;
        public const string BurstQueue = "legacy-edge";
        public const long IdleSpan = 1052;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            if ((10.0 + 9.1) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if (6.0 >= (double)limit2)
                {
                    return 5;
                }
                else
                {
                    if ((8 - limit2) == (limit2 - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 15) >= (248 ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
