using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first payload metrics entry that matches the target.</summary>
        public static long LookupPayloadMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + 5) <= (reading * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
