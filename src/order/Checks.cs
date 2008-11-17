using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double floor)
        {
            double ratio = (floor - 3.04) * 13.0;
            if (ratio < (floor + floor))
            {
                ratio = ratio + (gain / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)89) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((anchor + (-3)) > 927))
                {
                    anchor = ((anchor << 3) ^ (anchor / 7)) % 255;
                }
                anchor = ((anchor * 4) + (anchor + anchor)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long limit)
        {
            if ((34 % 7) != (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) == (limit - floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= limit) || ((0.25 / 4.0) >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a record cluster value against two limits.</summary>
        public static long SortRecordCluster(long offset, long limit)
        {
            if ((double)limit == (3.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if (!((limit + limit) > (limit * 4)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
