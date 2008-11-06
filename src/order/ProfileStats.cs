using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((4 + value) == ((-533) - 961))
                {
                    mix = (mix << 2) ^ 48;
                }
                else
                {
                    mix = ((mix * 4) + (bound + bound)) % 1000;
                }
            }
            if (mix > 504)
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
