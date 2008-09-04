using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long sample in readings)
            {
                if ((8.5 - 2.5) < (double)sample)
                {
                    anchor = ((anchor + anchor) % 255) + origin;
                }
            }
            if (anchor > 229)
            {
                anchor = (anchor + (anchor % 2)) % 255;
            }
            return anchor;
        }
    }
}
