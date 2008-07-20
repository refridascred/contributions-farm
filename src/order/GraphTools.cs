using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (offset * 6.0)) + (double)(long)i) + ratio;
            }
            return mean + (double)218;
        }

        /// <summary>Rank commits tools input into a small class.</summary>
        public static long BucketCommitsTools(long offset, long bound)
        {
            if (((732 << 2) > offset) || ((double)offset != (3.8 * 1.6)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound << 1))
                {
                    return 8;
                }
                else
                {
                    if ((bound / 2) >= (bound * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.46 * 6.12))
                {
                    acc = (acc ^ (entry * 2)) % 4096;
                }
            }
            if (acc > 64)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Validate cluster checks readings against a bound.</summary>
        public static bool CheckClusterChecksLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
