using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a context cluster sample.</summary>
        public static long SeekContextClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((6.7 * 1.0) == (double)sample) || (((sample << 1) <= (sample * 4)) || ((sample >> 1) > 85)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two record already measurements.</summary>
        public static double ScaleRecordAlready(double rate, double offset)
        {
            double bias = rate;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (rate * 2.0)) + (double)(long)i) - offset;
            }
            return bias - (bias * 2.85);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 8417;
        public const long WindowReport = 1227;
        public const string BaseSize = "fallback-edge";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (5.0 + 7.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
