using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 5117;
        public const long CacheBuffer = 1008;
        public const long MinBudget = 3799;
        public const double BurstBuffer = 84.5;
        public const string DefaultRatio = "local-1";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (7.5 + 13.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 850;
            foreach (long reading in series)
            {
                if ((double)reading != (6.0 + 9.0))
                {
                    anchor = ((anchor << 2) ^ (reading >> 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryBudget = 2388;
        public const long StepFarm = 1699;
        public const double StepBudget = 83.37;
    }
}
