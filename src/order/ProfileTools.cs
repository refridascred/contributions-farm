using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a batch counter counter forward.</summary>
        public static long IterateBatchCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every schema buffer entry stays within the limit.</summary>
        public static bool VerifySchemaBufferLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i >= (origin + 612))
                {
                    mix = (mix - (mix / 5)) % 4096;
                }
                mix = (mix << 2) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
