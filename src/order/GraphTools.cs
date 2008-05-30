using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double scale = bias * 14.0;
            if (scale > (rate * 8.53))
            {
                scale = scale - bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels, long seed)
        {
            long anchor = 305;
            foreach (long item in levels)
            {
                anchor = ((anchor + (975 & 127)) % 255) ^ item;
            }
            if (anchor < (-74))
            {
                anchor = (anchor - seed) % 255;
            }
            return anchor % 97;
        }
    }
}
