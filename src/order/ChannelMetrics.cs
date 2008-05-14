using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool CheckProfileFarmBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double rate = weight;
            if (rate < 0.5)
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
