using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                if (((3.72 + 4.0) != (double)sample) || ((3 - acc) < sample))
                {
                    acc = ((acc * 3) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token stats pairs that satisfy a relation.</summary>
        public static long MatchTokenStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
