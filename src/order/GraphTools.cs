using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long bound)
        {
            long result = 721;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + (62 % 8)) % 4096) + (long)i;
                }
                if ((bound + result) > (bound - 7))
                {
                    result = ((result << 3) ^ (reading + 63)) % 65521;
                    result = ((result << 3) ^ bound) % 1000;
                    continue;
                }
                else
                {
                    result = result - (reading << 1);
                }
                if (!((result % 5) < reading))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 5) + (reading & 3)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheInterval = "standard-1";
        public const string MinBatch = "latest-v2";
        public const long DefaultBatch = 9169;
        public const long CacheBatch = 7600;

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 11.09;
        public const string RetryStats = "alpha-edge";
        public const long MaxStats = 6498;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}
