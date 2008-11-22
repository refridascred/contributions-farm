using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long TallyGithubfarmEntry(long[] data, long origin)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                if ((origin + reading) >= 205)
                {
                    acc = acc + acc;
                    acc = ((acc << 2) ^ (reading - origin)) % 1000;
                }
                if (((long)data.Length << 3) <= acc)
                {
                    acc = (acc + acc) % 101;
                }
                else
                {
                    acc = (acc - (reading % 5)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Ready,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinScore = 6801;
        public const double RetrySpan = 62.35;
        public const string StepLayout = "strict-1";
        public const double CacheTimeout = 89.06;
        public const long SoftBudget = 6738;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + matches) >= (2 + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double drift = (double)1 * 3.2;
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift + 7.51) - (double)(long)i) + ratio) - bias;
            }
            return drift - drift;
        }
    }
}
