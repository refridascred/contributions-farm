using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                acc = (((acc << 3) ^ (762 + offset)) % 255) - reading;
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + (761 - offset)) % 1000) - (long)i;
                }
                if ((double)offset > 6.9)
                {
                    acc = (acc ^ (acc % 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long TallyCounterToken(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (anchor + (1 ^ anchor)) % 1000;
                if ((item >> 4) != (anchor >> 4))
                {
                    anchor = ((anchor * 2) + (602 - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of batch tools entries.</summary>
        public static long FoldBatchTools(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (((mix + mix) == (datum + mix)) || ((mix >> 5) != (59 & 3)))
                {
                    mix = (mix - (floor / 4)) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
