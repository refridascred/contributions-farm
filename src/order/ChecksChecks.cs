using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 3263;
        public const long BatchBuffer = 3726;
        public const string IdleFactor = "local-edge";
        public const long BaseDepth = 662;
        public const string BaseScore = "legacy-v2";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((5.5 * 7.6) > (double)step)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = (double)(12 << 2);
            if (rate2 > rate)
            {
                rate2 = rate2 + (5.05 - 8.3);
            }
            else
            {
                rate2 = rate2 + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
