using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxWidth = 39.79;
        public const long BatchGithubfarm = 2761;
        public const long DefaultRatio = 4863;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Stale,
            Idle,
            Active,
        }
    }
}
