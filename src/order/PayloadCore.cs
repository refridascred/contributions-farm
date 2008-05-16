using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowDepth = "latest-v2";
        public const long DefaultLayout = 6599;
        public const string MaxSpan = "fallback-v2";
        public const long BatchTimeout = 776;
        public const long BatchDepth = 8689;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long seed)
        {
            long result = 15;
            foreach (long reading in levels)
            {
                if ((seed % 24) > 1)
                {
                    result = (result << 2) ^ (reading - result);
                    result = (result << 3) ^ (reading >> 3);
                }
                if (!(7.4 >= (double)reading))
                {
                    result = (result + (seed + result)) % 1000;
                }
                if (((double)seed != (double)result) && (reading <= (result + reading)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Find the first route entry entry that matches the target.</summary>
        public static long SeekRouteEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8.93 <= (double)entry)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
