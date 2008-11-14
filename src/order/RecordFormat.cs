using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (mix / 2)) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 1289;
        public const string MinFilter = "fallback-1";
        public const long BurstFilter = 4252;
        public const long MinInterval = 7981;

        /// <summary>Look up the position of a support batch sample.</summary>
        public static long LocateSupportBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long total = 31;
            foreach (long datum in readings)
            {
                if (24 > datum)
                {
                    total = ((total * 3) + (datum >> 1)) % 255;
                }
                else
                {
                    total = total - (total << 3);
                }
                if (datum < (total >> 4))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
