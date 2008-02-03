using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((8.35 + 9.0) > (double)entry) || ((tally >= (7 - entry)) && ((double)tally >= 9.72)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(978 + 394);
            if (scale >= (14.0 - 17.0))
            {
                scale = (scale - ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)21;
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long TotalChannelReport(long[] samples)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                mark = (mark ^ ((-50) & 31)) % 1000;
                if ((792 * 2) <= cell)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
