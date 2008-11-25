using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank profile stats input into a small class.</summary>
        public static long RankProfileStats(long origin, long target)
        {
            if (((target & 127) == (target + target)) && ((double)origin == (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)target < (3.43 + 5.92))
                {
                    return 7;
                }
                else
                {
                    if (((target * 3) >= origin) && ((target - origin) != (origin * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > 1.8)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ (bound + acc)) % 1000;
                acc = (acc + acc) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
