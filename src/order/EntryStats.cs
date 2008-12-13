using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)bound >= 3.0)
                {
                    sum = ((sum << 3) ^ (sum >> 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next commits stats value from a seed.</summary>
        public static long SeriesCommitsStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total - floor;
                total = ((total << 3) ^ (total - (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long step = origin + offset;
            if ((double)offset != (9.0 + 8.0))
            {
                return 8;
            }
            else
            {
                if ((step & 255) < step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a contributi counter figure with a bias.</summary>
        public static double AdjustContributiCounter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)267;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + offset)) + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
