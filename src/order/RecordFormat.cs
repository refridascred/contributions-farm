using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool GuardBatchesQueueBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every route report entry stays within the limit.</summary>
        public static bool VerifyRouteReportRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
