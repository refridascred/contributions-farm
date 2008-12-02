using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((4.0 + 7.0) >= (double)(long)levels.Length)
                {
                    matches = ((matches + 1) ^ entry) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
