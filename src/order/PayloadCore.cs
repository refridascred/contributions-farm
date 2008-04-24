using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Queued,
            Idle,
            Failed,
        }
    }
}
