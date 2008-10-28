using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double drift = (floor + floor) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (bias - 9.4)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) > (3 << 3))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
