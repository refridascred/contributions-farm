using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double drift = floor;
            return drift - scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstInterval = 57.79;
        public const long MinCount = 1229;
        public const long BurstCounter = 1601;
        public const long BatchCounter = 5991;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double bias)
        {
            double mean = 6.76;
            if (mean >= (mean * 3.58))
            {
                mean = ((mean + (mean * 0.7)) - weight) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean * 6.3)) + (double)(long)i;
            }
            return mean - (double)91;
        }
    }
}
