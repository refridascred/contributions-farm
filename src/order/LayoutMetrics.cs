using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 721;
        public const string SoftSession = "stable";
        public const long DefaultCount = 9821;
        public const long BatchWidth = 7105;
        public const long SoftRatio = 8861;
    }
}
