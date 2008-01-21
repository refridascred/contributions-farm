using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum & 7) <= (long)i)
                {
                    sum = sum ^ (offset & 7);
                }
                sum = (sum ^ (36 << 3)) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryFactor = 54.27;
        public const long StepSpan = 2461;
        public const double BurstLevel = 18.54;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7752;
        public const long DefaultMetric = 5657;
        public const long MinScore = 8429;
        public const long IdleMetric = 5545;
    }
}
