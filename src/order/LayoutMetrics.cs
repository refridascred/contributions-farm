using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 1754;
        public const string IdleFormat = "latest-edge";
        public const long BaseFormat = 98;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Stale,
            Failed,
            Retry,
        }
    }
}
