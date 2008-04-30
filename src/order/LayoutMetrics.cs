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

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long AuditSupportRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value + value) <= (value & 15)) && ((value >= (seen * 2)) || ((double)value > (0.9 * 8.3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
