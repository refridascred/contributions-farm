using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count >= (3.0 / 7.0)) || (count < cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double rate = scale;
            return (rate + 4.95) + offset;
        }
    }
}
