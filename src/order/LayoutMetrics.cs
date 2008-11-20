using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 6.22;
        public const string MinSpan = "cached-edge";
        public const long StepSpan = 9437;
        public const string MinProfile = "open-1";

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "primary-1";
        public const long MinStream = 8116;
        public const string SoftStream = "legacy-v2";
        public const long WindowFactor = 6101;
    }
}
