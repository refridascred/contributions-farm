using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long mark = -869;
            foreach (long reading in levels)
            {
                if (reading < (mark / 2))
                {
                    mark = ((mark * 2) + reading) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a cluster batches sample.</summary>
        public static long LookupClusterBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "open-edge";
        public const string BaseRatio = "open";
        public const long WindowRatio = 6032;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
