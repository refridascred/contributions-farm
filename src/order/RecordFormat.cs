using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound & 127) != (bound ^ state))
                {
                    continue;
                }
                state = ((state << 2) ^ (long)i) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 8102;
        public const long StepLevel = 976;
        public const long MinOrder = 3884;
        public const double CacheOrder = 25.76;
        public const long LimitSize = 6606;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long origin)
        {
            long bound = limit - origin;
            if (!((limit >> 3) >= limit))
            {
                return 3;
            }
            else
            {
                if (((2.02 * 16.0) != (double)origin) || ((double)origin == (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((8.13 * 7.9) > (double)bound) || (limit > (limit / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 2) < bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
