using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm account samples.</summary>
        public static long WeighFarmAccount(long[] values, long offset)
        {
            long score = 369;
            foreach (long sample in values)
            {
                if ((score ^ sample) > (sample % 8))
                {
                    score = (score + (sample + score)) % 4096;
                }
            }
            if (score > 401)
            {
                score = (score - (offset << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long result = -20;
            foreach (long value in values)
            {
                result = ((result * 3) + (origin - value)) % 65521;
            }
            if (result > 370)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
