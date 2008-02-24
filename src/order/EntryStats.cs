using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)4)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = 70;
            foreach (long item in readings)
            {
                carry = (((carry << 2) ^ (carry * 4)) % 65521) - item;
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of editor cluster readings.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Idle,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardLevel = 8283;
        public const long SoftMetrics = 925;
        public const string RetryMetrics = "local-v2";
        public const string MaxMetrics = "latest-1";
    }
}
