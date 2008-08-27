using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long FoldCounterRoute(long[] data)
        {
            long result = 763;
            foreach (long value in data)
            {
                result = ((result + result) % 65521) - value;
                if ((result + result) < result)
                {
                    result = ((result * 3) + (result % 8)) % 101;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
