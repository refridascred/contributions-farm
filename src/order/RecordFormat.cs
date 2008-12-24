using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long TallyClusterAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor / 3) == (tally & 15))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long bound)
        {
            if ((bound * 2) < target)
            {
                return 6;
            }
            else
            {
                if ((bound - bound) > target)
                {
                    return 8;
                }
                else
                {
                    if ((double)target > 2.6)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound ^ 151) > (target * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5338;
        public const string RetryScore = "local-edge";
        public const long BatchFactor = 3256;
        public const long IdleTimeout = 9096;
        public const long CacheBatches = 3201;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = (mix * 4) + (4 % 10);
                if (!((mix % 12) >= (cell % 60)))
                {
                    mix = ((mix * 4) + cell) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix >> 2)) % 4096;
                }
                if (((-8) < limit) || ((mix / 7) >= (180 << 2)))
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }
    }
}
