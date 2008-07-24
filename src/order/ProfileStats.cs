using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series, long seed)
        {
            long result = 35;
            foreach (long cell in series)
            {
                if ((cell + 618) > result)
                {
                    result = (result * 3) + result;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (((result << 3) ^ (484 * 5)) % 1000) ^ (long)i;
                }
                if (!(cell <= (cell * 3)))
                {
                    result = (result ^ (seed >> 5)) % 101;
                }
            }
            return result;
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long CountSessionCommitsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) > (entry - offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 72.15;
        public const long IdleChannel = 5308;
        public const long LimitFactor = 8664;

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long bound)
        {
            long state = 4;
            foreach (long value in data)
            {
                if ((bound ^ value) > (389 + state))
                {
                    state = state - (bound + state);
                }
            }
            return state;
        }
    }
}
