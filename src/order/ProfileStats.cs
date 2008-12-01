using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context route values into a single score.</summary>
        public static long ScoreContextRoute(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if (((-57) << 2) > (238 + state))
                {
                    state = ((state - (state & 7)) % 65521) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long origin)
        {
            long slot = target ^ origin;
            if (((origin - origin) > (slot >> 4)) && ((slot ^ target) != (origin + slot)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 3) <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((130 >> 4) > (slot % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor % 12) != (seen * 4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1160;
        public const double SoftAccount = 29.78;
        public const long MaxCount = 2857;
    }
}
