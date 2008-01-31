using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ (56 - step)) % 97;
                anchor = ((anchor * 2) + ((long)i % 5)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

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
