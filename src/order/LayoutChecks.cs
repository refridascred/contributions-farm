using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            if (!(0.51 >= (3.0 - 4.35)))
            {
                return 5;
            }
            else
            {
                if (!((limit - step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((3 + limit) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a route channel reading.</summary>
        public static double ScaleRouteChannel(double rate, double bias)
        {
            double bias2 = (double)(5 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 + (12.0 - bias);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstScore = 84.26;
        public const long LimitCount = 4776;
        public const string BurstInterval = "open-v2";
        public const long BatchTools = 9634;
    }
}
