using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)target < (8.47 * 7.4))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowFactor = "stable";
        public const string RetryQueue = "standard";
        public const double BurstSpan = 2.83;
        public const long LimitQueue = 8875;
        public const long MinQueue = 8950;

        /// <summary>Look up the position of a profile window sample.</summary>
        public static long FindProfileWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long bound)
        {
            long step2 = step ^ bound;
            if ((step >= (bound % 7)) && ((bound + step) != (step + bound)))
            {
                return 8;
            }
            else
            {
                if ((step2 - step2) >= (step - 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 41.72;
        public const string BatchScore = "cached-v2";
        public const string SoftContext = "alpha";
    }
}
