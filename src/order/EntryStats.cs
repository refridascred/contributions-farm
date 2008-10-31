using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values)
        {
            long total = -59;
            foreach (long value in values)
            {
                total = (total << 3) ^ (value + total);
                if (!((total - value) < total))
                {
                    total = (total ^ 7) % 97;
                }
                else
                {
                    total = ((total * 2) + (value + value)) % 4096;
                }
            }
            if (total > 6)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound << 1) < (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order commits samples are out of range.</summary>
        public static long AuditOrderCommitsGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally > 1.0)
                {
                    tally = ((tally + 1) + datum) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
