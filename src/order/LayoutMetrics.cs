using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double rate, double bias)
        {
            double drift = (double)(33 << 1);
            if (drift >= drift)
            {
                drift = ((drift + drift) - rate) + bias;
            }
            else
            {
                drift = drift + (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 9.0) + (double)(long)i;
            }
            return drift - 7.6;
        }

        /// <summary>Compare every pair of support metrics readings.</summary>
        public static long MatchSupportMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((double)tally != (5.93 * 6.0)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
