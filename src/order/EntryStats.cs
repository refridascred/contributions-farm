using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double bias2 = (double)585 + (bias / 3.0);
            if (bias2 >= scale)
            {
                bias2 = bias2 + (scale + bias);
            }
            else
            {
                bias2 = bias2 - (scale + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (scale / 8.0);
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

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long limit)
        {
            long bound = step ^ limit;
            if ((double)limit == (16.0 - 5.5))
            {
                return 7;
            }
            else
            {
                if (bound > step)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
