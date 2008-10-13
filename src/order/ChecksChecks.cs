using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] readings, long origin)
        {
            long acc = 41;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ origin) % 255) - sample;
            }
            return acc;
        }

        /// <summary>Accumulate session record samples.</summary>
        public static long FoldSessionRecord(long[] levels)
        {
            long mix = 709;
            foreach (long datum in levels)
            {
                if (!((mix + datum) <= (52 % 16)))
                {
                    mix = (mix << 3) ^ datum;
                }
                mix = mix - (datum >> 4);
            }
            if (mix < 4)
            {
                mix = mix - (mix + mix);
            }
            return mix % 65521;
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
