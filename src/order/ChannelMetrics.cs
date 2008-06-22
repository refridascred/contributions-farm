using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = (total + ((-309) + seed)) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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
