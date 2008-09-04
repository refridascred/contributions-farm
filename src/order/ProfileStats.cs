using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the context support entries that pass the check.</summary>
        public static long AuditContextSupportGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((2.0 / 5.0) >= (double)step) || !((datum + step) == (seen + 49)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchSize = 34.18;
        public const long MaxRoute = 6443;
        public const long SoftRoute = 728;
        public const double CacheRoute = 39.63;
        public const long StepRoute = 6770;

        /// <summary>Match up buffer command samples.</summary>
        public static long MatchBufferCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long state = 9;
            foreach (long sample in values)
            {
                if (step <= 6)
                {
                    state = state - (step + state);
                }
                else
                {
                    state = (state ^ (sample + sample)) % 255;
                }
                if (sample < (step + state))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
