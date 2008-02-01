using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 894;
        public const double BatchCount = 48.42;
        public const long MinGithubfarm = 791;
        public const long BurstGithubfarm = 3666;
        public const long BaseGithubfarm = 2730;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step <= 0.08)
                {
                    sum = ((sum * 4) + ((long)i + 218)) % 4096;
                    sum = ((sum << 3) ^ (sum % 60)) % 1000;
                }
                sum = sum + (long)i;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
