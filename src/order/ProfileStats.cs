using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a graph tools figure with a bias.</summary>
        public static double AdjustGraphTools(double gain, double floor)
        {
            double rate = (4.85 * 19.0) - (floor / 2.0);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 77.68;
        public const long BurstFactor = 894;
        public const double BurstCount = 5.04;
        public const string LimitStats = "fallback-edge";

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long origin)
        {
            if (origin < (origin / 8))
            {
                return 3;
            }
            else
            {
                if ((origin << 2) >= (647 - floor))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
