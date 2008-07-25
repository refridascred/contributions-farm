using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long target)
        {
            long span = step + target;
            if ((step & 255) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.2 * 8.95) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((0.6 - 5.9) != (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
