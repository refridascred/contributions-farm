using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count / 9) > (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Locked,
            Closed,
            Paused,
            Idle,
        }
    }
}
