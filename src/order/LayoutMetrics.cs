using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches - (long)levels.Length))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 6617;
        public const long BaseFactor = 2583;
        public const long LimitToken = 254;
    }
}
