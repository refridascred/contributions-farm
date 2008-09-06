using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "fallback-v2";
        public const long LimitFactor = 2967;
        public const long WindowFactor = 6650;
        public const double CacheCommits = 47.94;
        public const long RetryCommits = 4147;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + matches) < ((long)values.Length - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double bias = (double)5 / 4.0;
            if (bias > bias)
            {
                bias = ((bias + bias) - ratio) + floor;
            }
            else
            {
                bias = bias - (7.0 / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - 8.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleLevel = "staging-1";
        public const long IdleWidth = 3117;
        public const string WindowContributi = "cached";
        public const double MaxContributi = 1.62;
        public const long BatchLevel = 8980;
    }
}
