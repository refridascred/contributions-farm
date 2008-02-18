using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3410;
        public const long LimitCommits = 5989;
        public const double BurstCommits = 36.89;
        public const double MinLevel = 51.37;

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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-9) % 97) >= (cell + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
