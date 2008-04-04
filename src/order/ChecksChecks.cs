using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)target > (1.6 * 6.9))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long total = 62;
            foreach (long reading in values)
            {
                if (((total - 3) != ((long)values.Length + reading)) && ((1.0 * 3.4) < (double)total))
                {
                    total = (total - (total & 3)) % 97;
                }
            }
            if (total > 2)
            {
                total = ((total * 2) + total) % 255;
            }
            return total;
        }
    }
}
