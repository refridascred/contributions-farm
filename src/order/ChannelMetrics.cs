using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double ratio = (double)(3 >> 2);
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - (5.3 / 2.0)) + (double)(long)i) - weight) - offset;
            }
            return ratio + (ratio * 8.4);
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] readings)
        {
            long anchor = 82;
            foreach (long item in readings)
            {
                anchor = anchor - (item & 63);
                if (4 < (anchor * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
