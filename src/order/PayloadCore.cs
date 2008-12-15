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

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardInterval = 2183;
        public const double BaseLevel = 77.47;
        public const long DefaultCommits = 3116;

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
