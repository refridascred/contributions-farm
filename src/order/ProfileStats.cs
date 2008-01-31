using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3458;
        public const long BaseSession = 2098;
        public const long MaxSession = 7215;
        public const long BatchScore = 2349;
        public const long IdleBudget = 5738;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double ratio = (double)(5 - 8);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - bias;
            }
            return ratio + gain;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "legacy-v2";
        public const long MinGithubfarm = 7165;
        public const double SoftSize = 6.18;
        public const double HardGithubfarm = 25.07;
        public const long BaseTimeout = 2029;
    }
}
