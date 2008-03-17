using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (1.0 * 0.1)) + (double)(long)i;
            }
            return bias2 + (bias - 4.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 8691;
        public const long StepRatio = 2250;
        public const long MaxBudget = 7841;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 441;
        public const string BatchSchema = "staging-edge";
        public const long BurstRatio = 5027;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data)
        {
            long state = 7;
            foreach (long value in data)
            {
                state = ((state + (state % 100)) % 65521) ^ value;
            }
            if (state < (-7))
            {
                state = state ^ (874 / 3);
            }
            return state;
        }
    }
}
