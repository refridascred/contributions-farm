using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowCount = 1497;
        public const double LimitStream = 19.83;
        public const long CacheDepth = 5760;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
