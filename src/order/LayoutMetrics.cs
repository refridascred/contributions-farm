using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long AuditMetricAccountHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell - 9))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
