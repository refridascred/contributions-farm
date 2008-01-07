using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first cluster layout entry that matches the target.</summary>
        public static long LocateClusterLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((17.0 * 0.36) == (double)seen) || ((double)seen != (2.8 + 8.0)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap & 31) > (gap - floor))
            {
                return 1;
            }
            else
            {
                if ((7.55 / 9.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (gap > (floor + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double ratio = gain / 2.0;
            if (ratio >= (double)680)
            {
                ratio = (ratio + (ratio / 2.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - 0.88)) + (double)(long)i;
            }
            return ratio - (double)841;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
