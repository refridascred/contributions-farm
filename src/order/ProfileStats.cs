using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 99;
            foreach (long item in samples)
            {
                acc = (((acc * 5) + (719 << 1)) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double BlendBatchesProfile(double weight, double bias)
        {
            double bias2 = (double)(0 ^ 24);
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + 2.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (5.0 - weight)) - (double)(long)i;
            }
            return bias2 - (double)97;
        }

        /// <summary>Accumulate batches githubfarm samples.</summary>
        public static long TotalBatchesGithubfarm(long[] data)
        {
            long acc = 65;
            foreach (long value in data)
            {
                if ((((-69) >> 4) != (acc + acc)) || ((acc % 97) <= (value % 3)))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc > 477)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc;
        }
    }
}
