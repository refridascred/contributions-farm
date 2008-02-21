using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double floor)
        {
            double gain2 = gain + (double)7;
            if (gain2 > (gain / 2.0))
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 - (gain + gain);
        }

        /// <summary>Blend two buffer window measurements.</summary>
        public static double ScaleBufferWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (2.96 - 2.63))
            {
                rate2 = (rate2 - (rate2 * 6.45)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate / 3.0)) - (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Done,
            Retry,
        }
    }
}
