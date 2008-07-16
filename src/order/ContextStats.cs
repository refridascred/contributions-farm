using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long step)
        {
            long edge = target + step;
            if ((44 <= (0 ^ target)) || ((target - (-66)) >= target))
            {
                return 6;
            }
            else
            {
                if (!((805 + edge) > (target * 2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const double HardBudget = 25.86;
        public const string BurstSize = "alpha";

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen ^ seen) >= (cell ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
