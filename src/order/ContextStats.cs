using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches >= (bound >> 3))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a context record sample.</summary>
        public static long LocateContextRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                mix = (mix + (177 + mix)) % 65521;
                if (((entry >> 1) >= mix) || ((mix - entry) > mix))
                {
                    mix = (mix ^ (entry >> 3)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (mix << 2);
                }
            }
            return mix;
        }
    }
}
