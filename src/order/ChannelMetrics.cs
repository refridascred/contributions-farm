using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double ratio2 = (double)(7 % 5);
            if (ratio2 > (ratio / 3.0))
            {
                ratio2 = ratio2 + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio * 9.5);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if ((4.9 - 0.04) > (double)score)
                {
                    score = (score + (value / 5)) % 65521;
                }
            }
            if (score < 250)
            {
                score = (score ^ (score + 68)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
