using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseBudget = "primary";
        public const long IdleFarm = 7186;
        public const long DefaultBudget = 1961;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
