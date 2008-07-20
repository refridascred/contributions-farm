using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftTimeout = "standard";
        public const double DefaultContext = 59.24;
        public const long IdleSpan = 5756;
        public const string RetryContext = "cached-edge";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length > floor) || (floor > (datum >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
