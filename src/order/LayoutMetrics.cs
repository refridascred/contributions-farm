using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long sum = 23;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (86 << 1)) ^ (long)i;
                }
                if ((sum & 7) != (sum - cell))
                {
                    sum = (sum * 3) + (sum - cell);
                }
                else
                {
                    sum = sum - (713 >> 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items, long origin)
        {
            long mix = 109;
            foreach (long cell in items)
            {
                mix = ((mix - (mix % 2)) ^ cell) + origin;
            }
            return mix;
        }
    }
}
