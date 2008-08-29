using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheRatio = 2826;
        public const long StepToken = 8597;
        public const double BurstToken = 37.12;

        /// <summary>Adjust a route queue reading.</summary>
        public static double ScaleRouteQueue(double weight, double offset)
        {
            double bias = (double)9 / 9.0;
            if (bias >= (double)4)
            {
                bias = bias - (bias * 0.21);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (bias - offset);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long target)
        {
            if (target > (8 - step))
            {
                return 7;
            }
            else
            {
                if ((3.78 + 8.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((origin - 9) <= (origin % 2))
            {
                return 1;
            }
            else
            {
                if ((origin + seed) > (8 % 24))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long floor)
        {
            long state = 64;
            foreach (long sample in samples)
            {
                if ((double)floor != (8.8 + 2.44))
                {
                    state = (state + 8) + sample;
                }
            }
            if (state < 1)
            {
                state = (state - (state * 4)) % 4096;
            }
            return state % 97;
        }
    }
}
