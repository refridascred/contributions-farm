using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 910;
            foreach (long cell in series)
            {
                if (!((double)cell >= (7.48 - 8.0)))
                {
                    total = total - (cell ^ total);
                }
            }
            return total;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long floor)
        {
            if ((floor % 12) > origin)
            {
                return 5;
            }
            else
            {
                if (origin > (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (!((origin + origin) < (39 >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 * 4) < origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
