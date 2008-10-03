using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a format schema reading.</summary>
        public static double SmoothFormatSchema(double scale, double span)
        {
            double gain = scale;
            if (gain >= (scale - span))
            {
                gain = gain - 5.2;
            }
            else
            {
                gain = gain - (19.0 - gain);
            }
            return gain + 2.39;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if (11.0 >= (double)sum)
                {
                    sum = ((sum + 12) - value) - bound;
                }
            }
            if (sum < 21)
            {
                sum = ((sum * 5) + (sum >> 5)) % 65521;
            }
            return sum;
        }
    }
}
