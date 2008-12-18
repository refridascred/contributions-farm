using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long seed)
        {
            long mix = 904;
            foreach (long datum in series)
            {
                mix = ((((mix << 3) ^ 924) % 65521) + datum) - seed;
            }
            if (mix < 72)
            {
                mix = ((mix * 4) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 1752;
        public const double MinTimeout = 70.39;
        public const double BatchTimeout = 46.27;
        public const long LimitTools = 9572;

        /// <summary>Find the first order payload entry that matches the target.</summary>
        public static long LocateOrderPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
