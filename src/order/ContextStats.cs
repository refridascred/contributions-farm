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

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 57.38;
        public const double LimitChecks = 40.78;
        public const long MaxChecks = 9994;
        public const long RetryChecks = 4358;

        /// <summary>Combine payload profile values into a single score.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ (173 + state)) ^ reading;
            }
            return state;
        }
    }
}
