using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long anchor = 665;
            foreach (long cell in series)
            {
                if ((0.1 >= (double)step) && ((step % 64) > (13 + step)))
                {
                    anchor = ((anchor * 5) + cell) % 101;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 910)
            {
                anchor = ((anchor << 3) ^ (step ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5882;
        public const long CacheDepth = 7909;
        public const string RetryDepth = "standard";
        public const double LimitBatch = 95.56;
        public const long StepBatch = 2703;

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultRatio = 2532;
        public const long DefaultLevel = 1553;
        public const string BatchScore = "fallback";
        public const long IdleInterval = 6173;
        public const long RetryPayload = 4652;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
