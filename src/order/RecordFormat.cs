using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel buffer value.</summary>
        public static double ScaleChannelBuffer(double rate, double bias)
        {
            double rate2 = 8.0 - rate;
            if (rate2 < (double)331)
            {
                rate2 = rate2 - (13.0 * 6.23);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Ready,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 7053;
        public const long CacheEntry = 9474;
        public const string SoftEntry = "cached-edge";

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long AuditSessionToolsGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (bound >= (item * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum > (datum ^ hits)) && (((datum & 1) < (hits & 1)) || ((datum << 3) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
