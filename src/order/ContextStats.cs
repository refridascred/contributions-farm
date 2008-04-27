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

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 43.5;
        public const long WindowRatio = 9631;
        public const string BatchTimeout = "legacy-v2";
        public const long BurstSpan = 84;
        public const long DefaultWidth = 5747;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
