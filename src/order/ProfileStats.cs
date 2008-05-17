using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long mix = 70;
            foreach (long reading in levels)
            {
                if (((4 + mix) > (mix - mix)) && (reading > (reading & 127)))
                {
                    mix = ((mix << 2) ^ (reading & 15)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = mix - (mix >> 5);
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items, long floor)
        {
            long mix = 922;
            foreach (long entry in items)
            {
                if (entry <= (entry + entry))
                {
                    mix = ((mix ^ (mix % 2)) % 97) + floor;
                }
            }
            if (mix > 63)
            {
                mix = ((mix * 3) + (mix + mix)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
