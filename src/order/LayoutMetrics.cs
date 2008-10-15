using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double gain2 = (7.7 - floor) + (double)(-20);
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain2 / 4.0)) + (double)(long)i;
            }
            return gain2 - (gain / 8.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2615;
        public const long BaseInterval = 8911;
        public const long MinRatio = 3529;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
