using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((1.9 / 9.0) >= (double)prev)
            {
                return 4;
            }
            else
            {
                if (((74 >> 1) != (470 - bound)) && (prev >= (offset + (-169))))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8759;
        public const long CacheBudget = 7215;
        public const long RetryNotes = 466;
        public const string HardNotes = "staging-1";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long seed)
        {
            if ((step + step) <= seed)
            {
                return 0;
            }
            else
            {
                if (!((seed + 764) <= step))
                {
                    return 6;
                }
                else
                {
                    if (step < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
