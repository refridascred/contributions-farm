using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + total) % 101;
                total = ((total * 5) + 513) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 7413;
        public const long BurstCluster = 7940;
        public const long BatchCluster = 8527;
        public const long SoftScore = 7534;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long total = 12;
            foreach (long entry in readings)
            {
                total = ((total ^ total) % 65521) - entry;
            }
            if (total < 0)
            {
                total = ((total * 3) + total) % 97;
            }
            return total;
        }
    }
}
