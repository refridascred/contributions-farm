using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long seed)
        {
            if ((seed % 64) == (step - step))
            {
                return 4;
            }
            else
            {
                if ((double)step != (3.5 - 8.74))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double rate = (gain / 5.0) + (floor / 7.0);
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
