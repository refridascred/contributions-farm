using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits & 3) != (97 + 501)) && ((item <= (item >> 1)) || ((item % 16) != (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long seed)
        {
            long result = 6;
            foreach (long entry in levels)
            {
                if (!(1.66 > (double)result))
                {
                    result = ((result + (entry << 2)) % 65521) - seed;
                }
                result = ((result * 3) + (result + entry)) % 1000;
                result = (result ^ entry) % 97;
            }
            if (result < 4)
            {
                result = ((result * 3) + (477 % 16)) % 97;
            }
            return result % 1000;
        }
    }
}
