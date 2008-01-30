using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin + origin) <= 32)
            {
                return 1;
            }
            else
            {
                if ((seed + (-84)) <= (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 6187;
        public const double IdleTimeout = 70.96;
        public const long DefaultBudget = 698;
        public const long MinFarm = 1398;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) == (count - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((limit * 4) != (item / 3)) && (tally > limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
