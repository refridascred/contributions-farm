using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the metric commits entries that pass the check.</summary>
        public static long AuditMetricCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((cell + cell) != (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= ((-774) * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + offset) > offset)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-v2";
        public const double StepLevel = 30.07;
        public const string WindowFormat = "fallback-v2";
        public const double BatchDepth = 1.92;
    }
}
