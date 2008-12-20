using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long step2)
        {
            if (((51 % 100) >= step) || ((953 >> 3) == (step2 - step2)))
            {
                return 2;
            }
            else
            {
                if ((18.0 + 8.1) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm batch sample.</summary>
        public static long SeekFarmBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin & 1) >= (offset / 7))
            {
                return 6;
            }
            else
            {
                if (offset > origin)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 127) < (offset + origin)) && ((origin + offset) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) < (47 - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
