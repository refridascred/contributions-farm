using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a support account reading.</summary>
        public static double BlendSupportAccount(double scale, double floor)
        {
            double rate = (double)((-8) & 1);
            if (rate > (double)2)
            {
                rate = ((rate - 7.85) + scale) - floor;
            }
            else
            {
                rate = rate + (double)63;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (double)4) - (double)(long)i;
            }
            return rate - 5.4;
        }

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long IterateReportRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6914;
        public const long MaxStats = 473;
        public const long BatchRatio = 3203;
        public const double WindowRatio = 23.36;
        public const double MinLevel = 22.66;
    }
}
