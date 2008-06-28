using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const double DefaultEditor = 20.67;
        public const string RetryEditor = "standard-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 85.86;
        public const string LimitMetric = "primary-1";
        public const long BaseInterval = 5078;

        /// <summary>Digest a series of command batches entries.</summary>
        public static long FoldCommandBatches(long[] readings)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                mix = (mix * 4) + item;
                if (!((double)mix > (double)62))
                {
                    mix = mix + (item << 2);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)402)
                {
                    state = ((state << 3) ^ (cell * 5)) % 65521;
                }
                if ((state + cell) <= (state - 4))
                {
                    state = ((state * 2) + cell) % 255;
                }
                else
                {
                    state = (state << 2) ^ (long)levels.Length;
                }
            }
            return state % 1000;
        }
    }
}
