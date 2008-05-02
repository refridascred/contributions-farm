using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((501 & 7) > ((long)samples.Length + matches))
                {
                    matches = ((matches + 2) ^ reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
