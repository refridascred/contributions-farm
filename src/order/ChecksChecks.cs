using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2089;
        public const double LimitFactor = 32.4;
        public const long HardAccount = 2108;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = (double)(479 * 4);
            if (gain >= (double)535)
            {
                gain = (gain + gain) - ratio;
            }
            else
            {
                gain = gain - 6.97;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (6.0 / 5.0);
        }
    }
}
