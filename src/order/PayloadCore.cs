using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double bias = weight + weight;
            if (bias > (double)2)
            {
                bias = bias + (double)780;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (floor / 3.0)) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Check that every cache stream entry stays within the limit.</summary>
        public static bool VerifyCacheStreamRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
