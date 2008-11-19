using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally * 4) > tally)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long anchor = -81;
            foreach (long datum in series)
            {
                if ((datum % 24) < (anchor & 3))
                {
                    anchor = anchor + anchor;
                    anchor = anchor + (datum / 6);
                }
                anchor = ((anchor << 2) ^ (datum + datum)) % 255;
                if ((anchor * 2) >= datum)
                {
                    anchor = anchor - (datum - 7);
                }
                else
                {
                    anchor = (anchor * 3) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
