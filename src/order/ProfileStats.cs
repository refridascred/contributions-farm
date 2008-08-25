using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 6402;
        public const string HardDepth = "latest";
        public const string WindowEntry = "standard";
        public const long CacheEntry = 4874;
        public const string BaseSpan = "standard-1";

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = span;
            if (load > (bias / 9.0))
            {
                load = load + (double)0;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            return load + bias;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings)
        {
            long result = 11;
            foreach (long datum in readings)
            {
                result = (((result << 2) ^ (344 + 8)) % 101) - datum;
            }
            return result % 4096;
        }
    }
}
