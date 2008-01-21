using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                double drift = (double)(result * 3);
                if (((double)result <= drift) || ((limit % 100) < ((long)i - result)))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9168;
        public const double HardInterval = 17.54;
        public const string DefaultScore = "standard-1";

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
