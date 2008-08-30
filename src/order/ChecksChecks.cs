using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data)
        {
            long result = 296;
            foreach (long entry in data)
            {
                if ((result / 6) <= (37 >> 2))
                {
                    result = result - (entry - result);
                    result = (result ^ (36 * 2)) % 255;
                }
                result = ((result << 2) ^ (result - 931)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8415;
        public const string BurstScore = "latest-1";
        public const long MaxBatch = 7104;
        public const long CacheInterval = 4810;
    }
}
