using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxCount = 49.53;
        public const long CacheSession = 2427;
        public const long WindowFactor = 1320;
        public const long SoftLevel = 7793;

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double weight = (2.0 - floor) + (double)873;
            if (weight > (double)913)
            {
                weight = weight + 4.6;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long bound)
        {
            long carry = -598;
            foreach (long sample in series)
            {
                carry = (carry + (carry / 9)) % 101;
                if ((carry ^ sample) > bound)
                {
                    carry = (carry + (carry / 4)) % 1000;
                }
            }
            return carry;
        }
    }
}
