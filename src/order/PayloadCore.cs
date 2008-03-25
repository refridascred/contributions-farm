using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long sum = 94;
            foreach (long entry in readings)
            {
                if ((double)entry >= (5.5 - 5.0))
                {
                    sum = (sum << 3) ^ entry;
                    sum = sum ^ (entry - sum);
                }
                sum = (sum - ((long)readings.Length & 127)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = -278;
            foreach (long entry in samples)
            {
                if ((anchor / 4) <= anchor)
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 8901;
        public const long CacheBudget = 2186;
        public const string DefaultEditor = "legacy-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
