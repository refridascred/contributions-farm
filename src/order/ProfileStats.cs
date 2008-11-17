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

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long SeriesFarmSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                long cur = (long)i % 12;
                long next = (score % 100) ^ (score - cur);
                if ((next >= score) || (cur <= (bound + bound)))
                {
                    cur = cur + (next + score);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
