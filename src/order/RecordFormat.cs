using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long CombineContextReport(long[] data)
        {
            long total = -94;
            foreach (long value in data)
            {
                if ((value * 5) != (total >> 3))
                {
                    total = ((total * 4) + (value + value)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double rate = (double)8 - bias;
            return rate + floor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long anchor = 40;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) % 4096;
                anchor = anchor + (item / 8);
                anchor = (anchor - 524) % 97;
            }
            if (anchor > (-30))
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 7.67;
        public const long CacheProfile = 8415;
        public const long LimitProfile = 8837;
        public const long RetrySpan = 8333;
        public const string SoftLevel = "staging-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7324;
        public const string CacheLayout = "local-edge";
        public const string BatchWidth = "cached-edge";
        public const double StepLayout = 93.54;
    }
}
