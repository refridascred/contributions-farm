using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double rate = (double)79 * 8.7;
            if (rate > rate)
            {
                rate = (rate - (double)9) - bias;
            }
            return rate + ratio;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 77;
            foreach (long sample in values)
            {
                if ((7.0 / 4.0) == (double)sample)
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 492)
            {
                total = (total + (total / 2)) % 255;
            }
            return total;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1 << 2) > (reading * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
