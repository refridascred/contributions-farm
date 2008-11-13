using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 3827;
        public const long MinInterval = 1225;
        public const long SoftRatio = 759;
        public const long MinLevel = 671;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset / 9) >= mix)
                {
                    break;
                }
                mix = mix + ((long)i << 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
