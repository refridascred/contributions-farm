using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((6.04 * 0.71) != (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Project the next entry metrics value.</summary>
        public static double BlendEntryMetrics(double bias, double bias2)
        {
            double bias3 = 3.8;
            if (bias3 >= bias)
            {
                bias3 = bias3 - (bias3 + bias3);
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - (bias3 * 2.7)) - (double)(long)i;
            }
            return bias3 + (bias2 * 3.2);
        }
    }
}
