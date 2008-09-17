using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank report cache input into a small class.</summary>
        public static long SortReportCache(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if (((next + 815) < (seed2 / 2)) && ((seed >> 2) >= (5 / 8)))
            {
                return 3;
            }
            else
            {
                if ((seed2 % 24) < seed)
                {
                    return 1;
                }
                else
                {
                    if (((11.0 - 0.6) == (double)next) && ((seed2 + seed) <= (seed2 * 4)))
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

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double weight = 3.68;
            if (weight < (scale / 7.0))
            {
                weight = (weight - (double)13) + bias;
            }
            return weight + scale;
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long CombineBatchQueue(long[] samples, long origin)
        {
            long state = 804;
            foreach (long reading in samples)
            {
                state = (state - (reading ^ (long)samples.Length)) % 1000;
                state = (state - (long)samples.Length) % 65521;
                if ((62 >= (state % 24)) && ((6.61 + 8.0) <= (double)state))
                {
                    break;
                }
            }
            if (state > 416)
            {
                state = (state << 3) ^ origin;
            }
            return state % 97;
        }
    }
}
