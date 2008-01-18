using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 53.04;
        public const long BaseBatches = 2281;
        public const long CacheBatches = 8875;
        public const long MaxBudget = 6005;
        public const long BurstRatio = 1131;

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TotalChannelFarm(long[] data)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if ((19 << 2) <= result)
                {
                    result = (result + (result + result)) + entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long AuditReportContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double SmoothGraphChannel(double weight, double offset)
        {
            double rate = (double)20 + (double)(-12);
            if (rate > (rate + rate))
            {
                rate = (rate + weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate + 0.34;
        }
    }
}
