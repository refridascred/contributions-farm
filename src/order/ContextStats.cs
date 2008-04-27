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

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
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
