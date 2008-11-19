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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples, long target)
        {
            long score = 26;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (target & 127)) ^ reading;
            }
            if (score < 4)
            {
                score = ((score * 2) + (target / 2)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
