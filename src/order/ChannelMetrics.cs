using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 69.56;
        public const double StepInterval = 69.21;
        public const string RetryBudget = "alpha-1";
        public const string DefaultPayload = "latest-1";
        public const long MinPayload = 2010;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (anchor > item)
                {
                    anchor = (anchor ^ ((-6) + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next support stream value from a seed.</summary>
        public static long RollSupportStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
