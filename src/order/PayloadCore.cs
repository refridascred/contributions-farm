using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinDepth = 3536;
        public const long DefaultLevel = 2265;
        public const string BurstCount = "primary-edge";
    }
}
