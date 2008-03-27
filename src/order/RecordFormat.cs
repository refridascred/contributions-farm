using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + 389) <= (seen / 9))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double scale = bias;
            if (scale > 17.0)
            {
                scale = (scale + scale) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 6.8)) + (double)(long)i;
            }
            return scale - (bias * 3.93);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardRatio = 98.11;
        public const long SoftSpan = 3855;
        public const long BaseCount = 6308;
        public const long BurstCount = 9425;
        public const double LimitSpan = 5.55;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long origin)
        {
            long bound = target - origin;
            if ((8.98 <= (double)target) || ((double)bound <= (3.5 - 5.0)))
            {
                return 1;
            }
            else
            {
                if (!((bound << 2) < bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 86.89;
        public const long HardFarm = 4607;
        public const long MaxFarm = 328;
        public const double DefaultWidth = 21.83;
    }
}
