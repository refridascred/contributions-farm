using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank buffer graph input into a small class.</summary>
        public static long GradeBufferGraph(long bound, long offset)
        {
            long prev = bound + offset;
            if ((offset / 3) == (prev + prev))
            {
                return 8;
            }
            else
            {
                if ((170 ^ prev) > (offset - bound))
                {
                    return 0;
                }
                else
                {
                    if (!((prev & 15) >= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(prev > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            long next = offset - target;
            if ((double)next <= (2.8 - 4.1))
            {
                return 7;
            }
            else
            {
                if ((999 + target) < (next + target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
