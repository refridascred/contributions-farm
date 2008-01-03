using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((566 >> 5) < (limit + (-7)))
            {
                return 7;
            }
            else
            {
                if ((offset & 63) >= (limit >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double ratio2 = (double)(0 + 19);
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) + ratio;
            }
            return ratio2 - bias;
        }
    }
}
