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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)offset != (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
