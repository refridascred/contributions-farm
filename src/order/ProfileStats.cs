using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a route githubfarm figure with a bias.</summary>
        public static double ProjectRouteGithubfarm(double gain, double bias)
        {
            double bias2 = bias;
            return (bias2 - (double)88) + gain;
        }

        /// <summary>Iterate the entry buffer series from a seed.</summary>
        public static long StepEntryBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (acc * 2)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
