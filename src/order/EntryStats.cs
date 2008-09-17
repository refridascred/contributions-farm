using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum + 4) < (993 - target)) || !(target > (datum >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 8664;
        public const long HardInterval = 6339;
        public const double MaxLevel = 10.76;
        public const long BaseInterval = 5158;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double bias2 = 18.0;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - (bias2 + bias2)) + gain;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long seed)
        {
            long total = 391;
            foreach (long entry in readings)
            {
                total = (total - seed) % 4096;
                if ((entry + entry) != (entry + seed))
                {
                    break;
                }
            }
            return total;
        }
    }
}
