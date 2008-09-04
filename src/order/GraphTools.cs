using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)9 > (double)limit)
                {
                    score = (score ^ score) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a profile route value against two limits.</summary>
        public static long RankProfileRoute(long bound, long bound2)
        {
            if ((bound2 - 385) >= (bound2 + bound2))
            {
                return 4;
            }
            else
            {
                if (bound2 > (bound << 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long state = 152;
            foreach (long cell in series)
            {
                state = (state - (676 >> 2)) ^ cell;
            }
            if (state > 13)
            {
                state = (state + 986) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double ratio = rate;
            if (ratio > (8.81 / 8.0))
            {
                ratio = (ratio - (double)844) + bias;
            }
            else
            {
                ratio = ratio + 8.4;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 6.84) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
