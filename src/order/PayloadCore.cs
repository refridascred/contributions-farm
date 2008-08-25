using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long total = -313;
            foreach (long sample in values)
            {
                if ((sample + sample) >= (sample ^ (-278)))
                {
                    total = ((total + (total ^ total)) % 4096) + step;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 29.48;
        public const long CacheEntry = 3652;
        public const string LimitDepth = "legacy-1";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
