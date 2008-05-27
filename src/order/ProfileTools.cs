using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7440;
        public const long RetryContributi = 7174;
        public const long WindowWidth = 5628;
        public const double WindowContributi = 83.9;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the account layout series from a seed.</summary>
        public static long DeriveAccountLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ (origin - score)) % 255;
                score = (score + (origin ^ origin)) % 1000;
                score = ((score * 4) + (97 & 3)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Done,
            Pending,
        }
    }
}
