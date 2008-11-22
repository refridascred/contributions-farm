using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 2749;
        public const long MinFactor = 1486;
        public const long DefaultWidth = 5847;
        public const string MaxFactor = "local-v2";

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
