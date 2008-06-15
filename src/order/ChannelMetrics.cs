using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 9720;
        public const long WindowInterval = 1203;
        public const long RetryCache = 1145;
        public const long DefaultCount = 3255;
        public const long SoftCache = 3988;

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if (((double)44 >= (double)state) && (state > (sample * 2)))
                {
                    state = ((state * 3) + (783 % 24)) % 97;
                }
                else
                {
                    state = state ^ (state / 8);
                }
                if ((sample / 2) <= state)
                {
                    break;
                }
            }
            if (state > (-453))
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long RollCounterFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (seed * 2);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
