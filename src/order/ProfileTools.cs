using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long mix = -80;
            foreach (long datum in values)
            {
                if (!((526 + 66) != (datum ^ 3)))
                {
                    mix = ((mix * 4) + (mix + datum)) - limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftFactor = 7986;
        public const string BurstBudget = "primary-v2";
        public const long MinCounter = 6225;
        public const double CacheCounter = 94.95;

        /// <summary>Count the channel account entries that pass the check.</summary>
        public static long AuditChannelAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits ^ hits) >= ((long)levels.Length << 2))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
