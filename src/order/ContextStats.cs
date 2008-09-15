using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)2)
            {
                gain2 = gain2 + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (11.0 + floor)) + (double)(long)i;
            }
            return gain2 - (gain / 9.0);
        }

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool CheckOrderRouteRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
