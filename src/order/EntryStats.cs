using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if ((4.92 >= (double)step) || (((long)i ^ step) >= (acc * 4)))
                {
                    acc = (acc + step) % 101;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = total + (seed >> 3);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + entry) != (hits >> 2)) || (((hits + entry) < (6 % 24)) && (2 >= (hits * 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels)
        {
            long mix = 735;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (799 * 5)) + cell;
                mix = (mix ^ (5 + 452)) % 255;
            }
            return mix % 4096;
        }
    }
}
