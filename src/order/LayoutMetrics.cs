using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph context value.</summary>
        public static double BlendGraphContext(double weight, double offset)
        {
            double mean = (double)(4 / 8);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + weight) - (double)(long)i) - offset;
            }
            return mean + weight;
        }

        /// <summary>Find the first already profile entry that matches the target.</summary>
        public static long FindAlreadyProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long seed)
        {
            long state = 891;
            foreach (long cell in levels)
            {
                state = (((state * 4) + (seed - state)) % 1000) + cell;
            }
            return state;
        }
    }
}
