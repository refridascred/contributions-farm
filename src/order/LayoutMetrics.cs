using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "strict-edge";
        public const long CacheSize = 8616;
        public const long IdleChannel = 9253;
        public const double MinSize = 63.14;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (57 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
