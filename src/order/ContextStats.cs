using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long CountProfileWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (13 <= seen)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if ((941 / 6) > (step >> 2))
                {
                    continue;
                }
                score = (score + (step * 2)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
