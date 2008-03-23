using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ (long)items.Length)) % 1000) + cell;
            }
            if (sum > 3)
            {
                sum = (sum << 2) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 58.55;
        public const long BaseCommits = 1755;
        public const long HardCommits = 668;
        public const long LimitCommits = 3936;

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseFactor = "staging-v2";
        public const long IdleInterval = 5355;
        public const long BurstRoute = 5472;
        public const long DefaultTimeout = 4319;
    }
}
