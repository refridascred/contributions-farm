using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const long IdleCount = 6957;
        public const long IdleInterval = 8530;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Stale,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches >= (7.0 + 16.0))
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics channel measurements.</summary>
        public static double SmoothMetricsChannel(double bias, double offset)
        {
            double mean = (bias * 7.8) + (double)6;
            if (mean > (double)7)
            {
                mean = (mean + (mean + bias)) + offset;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (mean - bias);
        }
    }
}
