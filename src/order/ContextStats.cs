using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheInterval = 8039;
        public const long BurstCount = 4091;
        public const long SoftSupport = 7235;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long result = 932;
            foreach (long item in values)
            {
                if ((long)values.Length <= (result - result))
                {
                    result = (((result * 4) + result) % 101) - item;
                }
                else
                {
                    result = (result * 5) + ((long)values.Length % 16);
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels, long seed)
        {
            long sum = 20;
            foreach (long reading in levels)
            {
                sum = ((sum ^ sum) ^ reading) - seed;
            }
            return sum % 4096;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double bias2 = (double)(9 - 75);
            if (bias2 > (double)2)
            {
                bias2 = (bias2 + (double)25) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (3.9 - offset)) + (double)(long)i;
            }
            return bias2 + (offset - bias2);
        }
    }
}
