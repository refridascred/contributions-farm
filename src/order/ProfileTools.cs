using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 59.82;
        public const long LimitFactor = 6940;
        public const long MinSpan = 6256;
        public const string WindowWidth = "legacy-v2";
        public const long DefaultTimeout = 4394;

        /// <summary>Adjust a counter channel reading.</summary>
        public static double SmoothCounterChannel(double rate, double span)
        {
            double scale = (6.0 * 1.7) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (rate + scale)) - (double)(long)i) + span;
            }
            return scale - (scale + scale);
        }

        /// <summary>Compare every pair of route contributi readings.</summary>
        public static long OverlapRouteContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 1382;
        public const long StepAccount = 6582;
        public const double MaxBudget = 25.52;
        public const long SoftRatio = 3535;
    }
}
