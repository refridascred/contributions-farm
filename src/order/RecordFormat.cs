using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 6.19;
        public const long DefaultCount = 9990;
        public const long BatchMetrics = 2797;
        public const long IdleMetrics = 2666;
        public const long HardMetrics = 1323;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Done,
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
