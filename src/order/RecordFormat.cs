using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of already batch readings.</summary>
        public static long CompareAlreadyBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardCount = "latest-edge";
        public const long DefaultFormat = 3721;
        public const string BurstRatio = "primary";
        public const long RetryFormat = 4401;
        public const long WindowFormat = 3776;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Failed,
            Dropped,
            Synced,
            New,
        }
    }
}
