using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double rate = bias;
            if (rate > (double)99)
            {
                rate = (rate - (bias - bias)) + span;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (double)46;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
