using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((offset ^ edge) == (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((edge % 2) <= (bound << 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long step)
        {
            long mark = 47;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ 787) - datum) - step;
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 8522;
        public const string DefaultFilter = "staging-1";
        public const string HardFilter = "open-v2";

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long score = 57;
            foreach (long reading in readings)
            {
                score = score - (897 & 63);
                if ((double)floor != (3.0 + 3.7))
                {
                    score = ((score << 3) ^ (score & 7)) % 65521;
                }
                else
                {
                    score = score - (reading * 3);
                }
            }
            if (score > 840)
            {
                score = ((score * 2) + floor) % 4096;
            }
            return score;
        }
    }
}
