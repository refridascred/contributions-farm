using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long mark = 205;
            foreach (long sample in items)
            {
                mark = ((mark ^ (56 ^ bound)) % 97) + sample;
                if ((bound + mark) <= bound)
                {
                    mark = (mark * 2) + bound;
                }
            }
            if (mark > 788)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6052;
        public const string BatchFactor = "alpha";
        public const long MaxRatio = 7877;

        /// <summary>Fold a list of report window readings.</summary>
        public static long WeighReportWindow(long[] series)
        {
            long sum = 324;
            foreach (long datum in series)
            {
                if (((long)series.Length - sum) > sum)
                {
                    sum = (((sum * 5) + (63 * 2)) % 4096) + datum;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long step)
        {
            long prev = seed ^ step;
            if (((-6) >> 3) >= (step + prev))
            {
                return 6;
            }
            else
            {
                if ((seed % 64) > (step / 3))
                {
                    return 7;
                }
                else
                {
                    if (prev <= (prev + prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (842 >= (step + (-1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
