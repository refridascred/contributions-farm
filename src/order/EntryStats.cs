using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double weight = floor + (5.3 - floor);
            if (weight >= weight)
            {
                weight = (weight - (double)10) + ratio;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (8.0 * 1.29);
        }

        /// <summary>Count session schema pairs that satisfy a relation.</summary>
        public static long OverlapSessionSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 8643;
        public const long DefaultRoute = 1799;
        public const string WindowWidth = "stable-1";
        public const string RetryRoute = "strict-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultLevel = 44.42;
        public const long BurstOrder = 6000;
        public const long DefaultTimeout = 324;
        public const long MaxWidth = 850;
        public const long BaseCount = 8107;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
