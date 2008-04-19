using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches / 2) == (sample << 1)) || (((341 - sample) <= (sample % 2)) || ((double)46 < (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum >= (count << 3))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long anchor = -3;
            foreach (long reading in series)
            {
                if ((480 - anchor) > reading)
                {
                    break;
                }
                anchor = anchor - reading;
            }
            return anchor % 97;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Idle,
            Locked,
            Active,
        }
    }
}
