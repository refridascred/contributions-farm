using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many contributi metrics samples are out of range.</summary>
        public static long CountContributiMetricsGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((seed >> 4) > seen) || ((seen + seen) < ((-4) / 3))) && !((seen + sample) > seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
