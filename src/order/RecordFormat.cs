using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxWidth = 29.95;
        public const long HardQueue = 364;
        public const double MinQueue = 64.97;
        public const long BaseQueue = 4229;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a context batches pair into a bucket.</summary>
        public static long BucketContextBatches(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((limit + slot) < (slot + slot))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (7.4 / 7.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (5.75 + 3.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (((bound ^ bound) >= gap) && ((bound * 3) > (157 & 7)))
            {
                return 1;
            }
            else
            {
                if ((gap ^ seed) <= (gap + bound))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound == (10.0 + 2.7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.64 * 11.0) > (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
