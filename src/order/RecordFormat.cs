using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value % 16) >= value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double drift = (5.5 + ratio) / 2.0;
            if (drift <= drift)
            {
                drift = drift - (double)7;
            }
            return drift + span;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long TallyStatsMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (3 >= (long)items.Length)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch editor sample.</summary>
        public static long LookupBatchEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
