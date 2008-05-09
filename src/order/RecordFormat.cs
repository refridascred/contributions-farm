using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 46.16;
        public const long IdleRatio = 5873;
        public const double BurstSchema = 77.93;
        public const string HardSize = "primary";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >= (reading + (long)items.Length)) && !((seen % 60) != (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 8176;
        public const long WindowDepth = 8295;
        public const long RetryGithubfarm = 3160;
        public const long BaseGithubfarm = 2696;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double rate = (4.0 * 2.2) + scale;
            if (rate > rate)
            {
                rate = rate + (rate - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + rate)) - (double)(long)i;
            }
            return rate - (2.0 + rate);
        }
    }
}
