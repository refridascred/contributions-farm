using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double AdjustCommandRecord(double gain, double floor)
        {
            double load = floor;
            return (load - (double)309) + gain;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
