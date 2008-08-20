using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 1085;
        public const long HardRatio = 9892;
        public const long BatchOrder = 1528;
        public const long DefaultOrder = 6440;
        public const long MaxOrder = 6030;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long acc = 895;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (item + item)) % 4096) + (long)i;
                    acc = (acc - (9 + item)) % 4096;
                }
                if ((item & 3) >= (acc / 3))
                {
                    acc = (acc ^ (item & 3)) % 97;
                }
            }
            if (acc > 433)
            {
                acc = acc - ((-8) & 63);
            }
            return acc;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine account format values into a single score.</summary>
        public static long TallyAccountFormat(long[] samples, long seed)
        {
            long mix = 825;
            foreach (long item in samples)
            {
                mix = (mix << 2) ^ mix;
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ item) + (long)i;
                }
                if ((mix & 127) == (seed + item))
                {
                    mix = (mix + (item ^ item)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
