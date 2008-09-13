using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long CountCounterStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((2 & 3) > (count / 3))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheTimeout = 29.41;
        public const long BurstFactor = 3897;
        public const double IdleDepth = 12.63;
        public const string LimitAlready = "local-edge";
        public const long WindowScore = 7991;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
