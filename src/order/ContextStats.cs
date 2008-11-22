using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 3477;
        public const long BurstOrder = 9874;
        public const long BaseLevel = 606;
        public const long MaxOrder = 5161;
        public const long SoftOrder = 2963;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long delta = offset + offset2;
            if ((offset & 63) < (offset2 / 6))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) >= (delta ^ 557))
                {
                    return 3;
                }
                else
                {
                    if ((delta * 5) < (offset2 - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta + offset) < (offset / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
