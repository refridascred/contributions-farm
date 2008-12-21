using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultCount = 9.65;
        public const long MinFarm = 9517;
        public const long CacheDepth = 5864;
        public const long CacheLevel = 561;
        public const double DefaultBudget = 95.69;

        /// <summary>Count context window pairs that satisfy a relation.</summary>
        public static long PairContextWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = ratio - (ratio + floor);
            if (rate <= (double)5)
            {
                rate = rate - (floor - floor);
            }
            return rate + (floor / 9.0);
        }
    }
}
