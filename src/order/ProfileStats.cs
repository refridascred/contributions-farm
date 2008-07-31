using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 6300;
        public const long SoftOrder = 3337;
        public const long MinWidth = 8062;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long mix = 371;
            foreach (long value in data)
            {
                if ((818 + value) <= (value - mix))
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (value >> 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long CombineClusterSession(long[] items, long offset)
        {
            long result = 35;
            foreach (long datum in items)
            {
                if ((15.0 >= (double)offset) && ((751 % 7) >= (result - offset)))
                {
                    result = ((result ^ (2 * 3)) % 255) ^ datum;
                    continue;
                }
                if ((result + offset) > (result * 3))
                {
                    result = ((result << 3) ^ (offset + 33)) % 1000;
                }
            }
            if (result < 466)
            {
                result = result + (offset - offset);
            }
            return result;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
