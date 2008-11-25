using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                if (bound <= (bound - bound))
                {
                    score = (score + 64) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 1000;
                    score = (score + (score * 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 4833;
        public const long IdleRoute = 4296;
        public const long RetryRoute = 3088;
        public const long MinRoute = 4844;
        public const double WindowRoute = 1.4;

        /// <summary>Derive the next account layout value from a seed.</summary>
        public static long StepAccountLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long WeighProfileOrder(long[] levels, long offset)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (1.0 >= (double)state)
                {
                    state = state ^ (cell + offset);
                }
                else
                {
                    state = (state + (state + cell)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
