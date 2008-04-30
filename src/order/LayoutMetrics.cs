using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double weight2 = (weight - weight) + (floor - floor);
            if (weight2 < (floor * 16.0))
            {
                weight2 = weight2 + floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - floor) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((9 > sample) && !((matches - matches) > (sample & 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
