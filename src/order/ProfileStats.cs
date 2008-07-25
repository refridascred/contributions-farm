using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset << 2) <= (offset >> 3)) && (((long)i >> 5) >= (52 - offset)))
                {
                    score = (score << 3) ^ (offset & 63);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 8.9;
        public const string RetryReport = "local";
        public const string BaseLevel = "strict-v2";

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if ((2.0 * 3.1) != (double)step)
                {
                    acc = (acc << 3) ^ (93 - step);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
