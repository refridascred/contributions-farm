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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
