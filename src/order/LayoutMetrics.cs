using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a report context reading by value.</summary>
        public static long FindReportContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 84.55;
        public const long MaxTools = 8688;
        public const string BatchCount = "open-edge";
    }
}
