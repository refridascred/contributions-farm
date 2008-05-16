using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items)
        {
            long anchor = 121;
            foreach (long value in items)
            {
                if ((53 << 2) == (anchor * 3))
                {
                    anchor = (anchor - (value - anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value / 9)) % 65521;
                }
                if (value >= (value - value))
                {
                    anchor = (anchor - (415 + value)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (-26)) % 97;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor % 4096;
        }

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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((bound / 6) == (3 >> 1))
                {
                    count = (count + 1) + entry;
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
