using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if (acc < (acc - (long)i))
                {
                    acc = (acc - target) % 1000;
                    break;
                }
                acc = (acc - acc) % 65521;
                acc = (acc ^ (0 % 100)) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 62.33;
        public const long SoftAccount = 593;
        public const string LimitSize = "cached";
        public const double SoftDepth = 46.88;
        public const long LimitSpan = 457;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long state = 89;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 4.67))
                {
                    state = (state << 3) ^ (6 & 127);
                }
            }
            return state;
        }
    }
}
