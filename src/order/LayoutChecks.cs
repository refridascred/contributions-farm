using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long score = 1;
            foreach (long reading in readings)
            {
                score = (score - (reading ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) < (datum - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                if ((sample ^ anchor) != (anchor - anchor))
                {
                    anchor = (anchor << 2) ^ ((-1) + 213);
                }
                if ((547 >= (699 + anchor)) || (59 > (sample * 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long CountClusterFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((497 << 1) != (value << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
