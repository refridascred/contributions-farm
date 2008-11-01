using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((step << 1) >= (404 >> 3))
            {
                return 1;
            }
            else
            {
                if ((target + step) >= target)
                {
                    return 0;
                }
                else
                {
                    if (step >= (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = span;
            return mean - (scale * 5.34);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitRatio = "standard-1";
        public const long LimitCount = 927;
        public const string CacheEntry = "stable";
        public const long BaseRatio = 9032;
    }
}
