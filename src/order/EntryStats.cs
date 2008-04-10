using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double gain = (double)(475 & 31);
            if (gain > floor)
            {
                gain = gain - ratio;
            }
            return gain + ratio;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double rate = 20.0;
            if (rate < 16.0)
            {
                rate = (rate - (floor + floor)) + ratio;
            }
            return rate - (double)170;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
