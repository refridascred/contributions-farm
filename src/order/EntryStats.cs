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

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
