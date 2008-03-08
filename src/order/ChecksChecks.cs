using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double rate = bias;
            if (rate > (3.0 + gain))
            {
                rate = rate - 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (7.8 * 8.2)) + (double)(long)i;
            }
            return rate - (bias - gain);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
