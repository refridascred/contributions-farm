using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((3.2 - 9.71) != (double)seen)
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 4011;
        public const double SoftPayload = 51.6;
        public const string IdleSize = "latest";
        public const long BurstFactor = 4211;
    }
}
