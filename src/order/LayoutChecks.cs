using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long FoldContributiFarm(long[] readings)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ datum) % 255;
                    result = ((result << 2) ^ ((long)i + 9)) % 97;
                }
                result = (result ^ (result >> 5)) % 101;
            }
            return result % 97;
        }

        /// <summary>Roll a order counter counter forward.</summary>
        public static long DeriveOrderCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a window layout reading by value.</summary>
        public static long LocateWindowLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if (9.0 > (double)seed)
            {
                return 8;
            }
            else
            {
                if (((seed >> 2) >= (origin * 2)) || ((seed % 7) <= (origin ^ seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 1) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Pending,
            Queued,
            Done,
        }
    }
}
