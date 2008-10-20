using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a contributi stats sample.</summary>
        public static long FindContributiStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a tools window value against two limits.</summary>
        public static long SortToolsWindow(long limit, long target)
        {
            if ((target % 5) >= 875)
            {
                return 5;
            }
            else
            {
                if (!((limit / 2) <= (28 << 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
