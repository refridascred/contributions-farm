using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Closed,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = scale + (double)776;
            if (gain <= (gain + scale))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (bias + scale);
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long ScoreFormatNotes(long[] items, long step)
        {
            long carry = 85;
            foreach (long cell in items)
            {
                if ((carry <= (cell * 3)) || ((step * 5) < (cell + 50)))
                {
                    carry = ((carry << 2) ^ (carry - 80)) % 4096;
                }
            }
            return carry;
        }
    }
}
