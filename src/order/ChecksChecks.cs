using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data)
        {
            long mark = 981;
            foreach (long cell in data)
            {
                if (mark <= (mark >> 3))
                {
                    mark = (mark ^ (cell + 0)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (7 >> 1);
                }
            }
            if (mark > 85)
            {
                mark = ((mark * 3) + (mark % 8)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((result + bound) != (bound * 4)))
                {
                    result = (result * 3) + ((long)i + bound);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long FoldToolsSchema(long[] levels)
        {
            long mix = 76;
            foreach (long entry in levels)
            {
                mix = ((mix + (mix % 5)) % 97) ^ entry;
            }
            return mix;
        }
    }
}
