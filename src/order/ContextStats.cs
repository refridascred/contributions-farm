using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double gain = 13.0;
            return (gain + (weight - weight)) + offset;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                if (6.55 > (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 255;
                }
                else
                {
                    state = (state + sample) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed + seed) >= seed2)
            {
                return 0;
            }
            else
            {
                if (6 <= (25 + next))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
