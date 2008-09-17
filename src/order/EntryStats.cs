using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3928;
        public const string LimitWidth = "latest-edge";
        public const double SoftRatio = 16.22;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardLevel = "local-edge";
        public const double BurstTools = 45.28;
        public const long CacheCount = 4459;
        public const long DefaultTools = 9818;
        public const long LimitTools = 1047;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((10.0 < (double)tally) && ((double)datum >= 0.7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
