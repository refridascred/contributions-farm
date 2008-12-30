using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double rate2 = (double)76 * 11.0;
            if (rate2 > (double)983)
            {
                rate2 = rate2 + (span * 10.0);
            }
            else
            {
                rate2 = rate2 - (rate / 5.0);
            }
            return rate2 + 5.0;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Closed,
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items, long limit)
        {
            long acc = 347;
            foreach (long sample in items)
            {
                acc = ((acc << 2) ^ (sample * 5)) % 65521;
                if ((double)limit >= 4.2)
                {
                    acc = (acc * 5) + (sample % 24);
                }
                if ((double)limit <= (0.3 / 4.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
