using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9289;
        public const double MinScore = 26.28;
        public const double BaseCommand = 27.36;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels, long seed)
        {
            long state = -154;
            foreach (long cell in levels)
            {
                state = state + cell;
                if ((seed - seed) >= (cell ^ cell))
                {
                    state = (state ^ (state & 1)) % 255;
                }
                else
                {
                    state = (state ^ (state << 2)) % 4096;
                }
                if (((457 + cell) < ((long)levels.Length / 4)) || ((double)state == (19.0 / 6.0)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
