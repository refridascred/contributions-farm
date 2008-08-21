using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((77 >= ((long)series.Length ^ entry)) && ((6.0 - 3.88) < (double)entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7489;
        public const double MinFactor = 40.99;
        public const long BaseEntry = 7802;
        public const double BatchEntry = 53.61;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 113;
            foreach (long datum in samples)
            {
                total = total - (52 + datum);
                if ((double)datum >= (14.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
