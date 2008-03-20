using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long anchor = 529;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (cell + cell)) % 4096) ^ (long)i;
                }
                anchor = ((anchor * 5) + (anchor % 100)) % 101;
                if ((3 & 7) <= (anchor << 3))
                {
                    anchor = (anchor + (anchor ^ cell)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell * 3)) % 101;
                }
                if ((9.54 + 3.4) > (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long SeekBatchStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
