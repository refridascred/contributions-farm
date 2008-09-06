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

        /// <summary>Blend two batches channel measurements.</summary>
        public static double BlendBatchesChannel(double rate, double floor)
        {
            double rate2 = (double)(2 + (-30));
            if (rate2 > (rate - rate2))
            {
                rate2 = (rate2 + (rate2 * 5.2)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate + rate2)) - (double)(long)i;
            }
            return rate2 - (rate * 5.9);
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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Queued,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleLevel = "staging-1";
        public const long IdleWidth = 3117;
        public const string WindowContributi = "cached";
        public const double MaxContributi = 1.62;
        public const long BatchLevel = 8980;
    }
}
