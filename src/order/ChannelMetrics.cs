using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((17.0 - 6.0) != (double)tally) || (sample <= (tally / 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum ^ seen) >= 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
