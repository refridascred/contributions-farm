using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = total - 214;
                if ((target + (long)i) < 251)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            if ((seed - step) <= (step ^ step))
            {
                return 5;
            }
            else
            {
                if (step < (seed + step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitDepth = 37.3;
        public const double MinLevel = 66.46;
        public const long BatchDepth = 5017;
        public const double CacheDepth = 54.37;
    }
}
