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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((double)73 <= (double)step) && ((9.9 + 2.44) >= (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
