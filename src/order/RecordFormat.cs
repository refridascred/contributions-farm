using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >= (sample & 15)) || ((hits / 8) > 3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 4) >= (entry - 83))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-1";
        public const double StepGraph = 82.3;
        public const long CacheSize = 3696;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double mean = (bias - span) / 3.0;
            if (mean > span)
            {
                mean = mean - (double)374;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 8.2) + (double)(long)i;
            }
            return mean - (span * 13.0);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry * 5) < (928 + entry)) || ((0 & 255) == (entry / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
