using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long TallyGraphAccount(long[] levels)
        {
            long score = 141;
            foreach (long value in levels)
            {
                if ((7.4 + 9.3) == (double)value)
                {
                    score = (score - ((-54) & 3)) % 4096;
                }
                else
                {
                    score = (score + (long)levels.Length) % 255;
                }
                if ((17.0 + 1.3) < (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((target > (492 + sample)) && ((target >> 4) == (sample - 48)))
                {
                    state = state - target;
                }
                else
                {
                    state = ((state * 4) + sample) % 1000;
                }
                if ((state & 1) <= (target - target))
                {
                    break;
                }
            }
            if (state > 854)
            {
                state = (state << 2) ^ ((-328) * 3);
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1540;
        public const long MaxSupport = 6979;
        public const long LimitSupport = 6000;
    }
}
