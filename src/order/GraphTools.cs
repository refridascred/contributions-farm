using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((score >> 2) <= (seed % 2)))
                {
                    score = ((score << 2) ^ seed) % 255;
                    score = (score * 2) + (710 * 2);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= 5.57)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples)
        {
            long total = 45;
            foreach (long cell in samples)
            {
                total = (total - total) % 101;
                if ((cell * 2) > (total + (long)samples.Length))
                {
                    total = ((total * 5) + (cell << 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen > (seen * 5)) && (((-274) / 9) == (entry & 255))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
