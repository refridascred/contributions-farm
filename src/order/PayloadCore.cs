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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (origin / 7)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
