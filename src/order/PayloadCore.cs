using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster batch entry that matches the target.</summary>
        public static long FindClusterBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (target * 2)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a filter checks figure with a bias.</summary>
        public static double SmoothFilterChecks(double scale, double bias)
        {
            double ratio = (double)(0 % 97);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + scale;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((2 & 63) != (9 - reading))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
