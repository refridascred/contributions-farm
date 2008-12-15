using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every queue order entry stays within the limit.</summary>
        public static bool GuardQueueOrderBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Done,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double span)
        {
            double gain = (span - ratio) + (double)58;
            if (gain > 4.2)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (18.0 / 4.0);
            }
            return gain - ratio;
        }
    }
}
