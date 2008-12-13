using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 80;
        public const long LimitRatio = 8614;
        public const long LimitWidth = 4785;

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long CountGraphCacheGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (bound > (bound ^ matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
