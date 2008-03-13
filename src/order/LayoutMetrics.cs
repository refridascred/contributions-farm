using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double ratio = weight;
            if (ratio < (double)(-18))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (double)703;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
