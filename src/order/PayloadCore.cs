using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long offset)
        {
            if (origin <= (offset + origin))
            {
                return 4;
            }
            else
            {
                if (((double)54 > (double)offset) && ((origin << 2) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset <= (7.8 * 2.5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long offset)
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

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftBudget = 3939;
        public const long BatchRoute = 9589;
        public const long DefaultRoute = 4679;
        public const long RetryRoute = 3301;
        public const long StepBudget = 1051;
    }
}
