using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 31.97;
        public const string RetryNotes = "stable-v2";
        public const long MinInterval = 9339;
        public const double MinWidth = 53.83;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long target)
        {
            if (target > origin)
            {
                return 0;
            }
            else
            {
                if ((target & 1) >= (origin + target))
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
}
