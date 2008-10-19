using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 2254;
        public const long DefaultSpan = 6461;
        public const long MaxWidth = 1843;

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double rate = bias / 6.0;
            if (rate < (double)4)
            {
                rate = (rate - bias) + span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)0) + (double)(long)i;
            }
            return rate + 3.64;
        }

        /// <summary>Fold a list of session schema readings.</summary>
        public static long FoldSessionSchema(long[] readings)
        {
            long mix = 30;
            foreach (long cell in readings)
            {
                mix = mix + (cell ^ cell);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate route commits samples.</summary>
        public static long WeighRouteCommits(long[] items, long step)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if ((item + item) > (item & 15))
                {
                    acc = ((acc - (acc + item)) % 255) + step;
                }
            }
            return acc;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long FoldCommandCounter(long[] samples, long seed)
        {
            long state = 69;
            foreach (long item in samples)
            {
                state = ((state ^ (seed + seed)) % 1000) ^ item;
            }
            if (state < 9)
            {
                state = (state ^ (seed >> 4)) % 101;
            }
            return state % 97;
        }
    }
}
