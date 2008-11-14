using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
