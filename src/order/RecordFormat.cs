using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Locate a checks filter reading by value.</summary>
        public static long LookupChecksFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((step << 1) > (step % 60)) && ((step ^ floor) <= (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) >= origin) && (72 >= step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Idle,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Iterate the cache window series from a seed.</summary>
        public static long RollCacheWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((mark % 100) > (mark + seed))
                {
                    mark = ((mark << 3) ^ ((long)i >> 2)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 4096;
                }
                mark = mark + seed;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
