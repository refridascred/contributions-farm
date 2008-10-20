using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats window readings against a rule.</summary>
        public static long AuditStatsWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 2) <= (99 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mark = -7;
            foreach (long entry in readings)
            {
                mark = ((mark * 5) + (entry >> 3)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (double)25)
            {
                scale = scale + (rate - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 9.87) + (double)(long)i;
            }
            return scale + offset;
        }
    }
}
