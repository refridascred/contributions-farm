using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - floor) % 255;
                if ((987 + floor) <= floor)
                {
                    mix = (mix * 3) + mix;
                    mix = (mix * 4) + ((long)i + floor);
                }
                else
                {
                    mix = (mix << 3) ^ floor;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
