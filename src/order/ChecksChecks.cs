using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((9.8 * 12.0) != (double)item)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache queue series from a seed.</summary>
        public static long IterateCacheQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (floor & 63)) % 4096;
                if ((floor * 2) > result)
                {
                    result = ((result * 4) + (long)i) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
