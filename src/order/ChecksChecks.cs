using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long MeasureMetricCacheMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((77 / 8) < (reading & 7)) || (step <= (seen - 540))) || ((double)reading <= (0.57 / 8.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0 - seen) <= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
