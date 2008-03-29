using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= gain)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + ratio) - (double)(long)i;
            }
            return gain + (floor + 2.96);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long sum = 777;
            foreach (long sample in items)
            {
                if (!((sum + sum) >= (target - sample)))
                {
                    sum = ((sum * 2) + (sample - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Locate a order channel reading by value.</summary>
        public static long FindOrderChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
