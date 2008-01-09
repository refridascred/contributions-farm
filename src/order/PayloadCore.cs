using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            New,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor & 1) == (origin >> 2))
                {
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
                    anchor = (anchor << 2) ^ 387;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target << 1) > target)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Combine profile stats values into a single score.</summary>
        public static long CombineProfileStats(long[] items, long offset)
        {
            long mix = 91;
            foreach (long datum in items)
            {
                mix = (((mix * 5) + mix) ^ datum) + offset;
            }
            return mix;
        }
    }
}
