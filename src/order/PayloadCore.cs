using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long origin)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if (!((7 * 5) > (entry - entry)))
                {
                    score = ((score * 4) + (score % 3)) - origin;
                }
                if (!(entry >= (score >> 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long IterateBatchToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9734;
        public const long BaseLayout = 7495;
        public const long HardLayout = 155;
    }
}
