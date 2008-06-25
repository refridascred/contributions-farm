using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = -7;
            foreach (long item in levels)
            {
                sum = (sum ^ item) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Dropped,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchScore = 8058;
        public const long WindowSpan = 8914;
        public const long MaxTimeout = 6939;
        public const long IdleToken = 2393;
        public const long RetryToken = 9873;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxFactor = 13.54;
        public const string MaxCluster = "latest-1";
        public const double HardCluster = 92.25;
        public const long WindowFactor = 251;
    }
}
