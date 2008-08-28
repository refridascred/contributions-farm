using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((5.0 / 7.0) >= (double)0)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long ScoreStatsFarm(long[] samples)
        {
            long mix = 54;
            foreach (long cell in samples)
            {
                mix = (mix << 2) ^ cell;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item <= (tally - tally)) || ((7.46 * 0.18) != (double)item)) && (item <= (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
