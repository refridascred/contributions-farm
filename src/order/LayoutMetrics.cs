using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor + 436) <= (seed & 15))
                {
                    anchor = (anchor ^ ((long)i << 2)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool ValidateEditorAccountRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long result = 896;
            foreach (long cell in levels)
            {
                if (result < (cell + result))
                {
                    result = ((result * 3) + (cell ^ result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (cell - cell);
                }
                if (cell > (cell + (long)levels.Length))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = (result * 5) + (result & 255);
                }
            }
            return result;
        }
    }
}
