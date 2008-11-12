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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Synced,
            Dropped,
        }

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
