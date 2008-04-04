using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Closed,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ score) % 4096) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
