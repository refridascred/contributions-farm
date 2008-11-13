using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long GradeProfileBatch(long seed, long target)
        {
            if (4.4 > (double)target)
            {
                return 4;
            }
            else
            {
                if (((target - seed) <= (target + seed)) || ((target >> 2) > 44))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 508) != (seed >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            long delta = bound ^ step;
            if (!((delta * 5) < 2))
            {
                return 3;
            }
            else
            {
                if ((step - delta) < (bound + step))
                {
                    return 5;
                }
                else
                {
                    if ((step + bound) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
