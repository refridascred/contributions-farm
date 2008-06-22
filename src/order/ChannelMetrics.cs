using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 3154;
        public const long DefaultAccount = 6511;
        public const string RetrySpan = "alpha-1";

        /// <summary>Fold a list of layout route readings.</summary>
        public static long DigestLayoutRoute(long[] samples, long step)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = (total ^ (total - sample)) - step;
            }
            return total;
        }
    }
}
