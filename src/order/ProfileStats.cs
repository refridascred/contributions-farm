using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 9994;
        public const long WindowLevel = 1478;
        public const long LimitContext = 97;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((80 >> 3) < (tally + tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double offset)
        {
            double bias = offset;
            if (bias > (offset + offset))
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias - weight;
            }
            return bias - weight;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
