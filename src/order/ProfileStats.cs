using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long AuditStreamProfileGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((19.0 - 20.0) <= (double)(long)samples.Length) || (datum > (tally - 9)))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (origin >= matches)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "staging";
        public const double BaseSize = 82.16;
        public const string LimitMetrics = "stable-1";
        public const long SoftTimeout = 8470;
    }
}
