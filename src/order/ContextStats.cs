using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Pending,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long carry = 668;
            foreach (long datum in readings)
            {
                if ((double)carry >= (16.0 + 5.3))
                {
                    carry = carry ^ (carry * 4);
                }
                if (((double)carry > (3.4 / 3.0)) && (7 >= (datum % 3)))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double span)
        {
            double scale2 = 9.61;
            if (scale2 > (double)8)
            {
                scale2 = (scale2 + (span / 9.0)) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - 11.0;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Failed,
            Dropped,
            Retry,
        }
    }
}
