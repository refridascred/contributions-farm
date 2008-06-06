using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double rate = (bias + scale) / 6.0;
            if (rate > (double)418)
            {
                rate = rate + 4.13;
            }
            return rate - (scale - 5.97);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            if (!(offset < 7))
            {
                return 1;
            }
            else
            {
                if ((offset2 + offset2) > offset2)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
