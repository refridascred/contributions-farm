using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the commits already entries that pass the check.</summary>
        public static long MeasureCommitsAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 4) <= (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema filter value from a seed.</summary>
        public static long IterateSchemaFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)floor <= (double)(long)i) && ((0 << 1) != (sum >> 5))))
                {
                    sum = (sum + sum) % 1000;
                    sum = (sum + (sum + floor)) % 65521;
                }
                if (((double)sum == (double)95) || ((double)floor == (double)(long)i))
                {
                    sum = (sum << 3) ^ (floor ^ 66);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long mix = -838;
            foreach (long item in data)
            {
                mix = (mix - ((long)data.Length / 6)) % 1000;
                if (((55 + item) == (item - mix)) || ((342 ^ item) < (item >> 4)))
                {
                    mix = (mix << 3) ^ (item + item);
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix;
        }
    }
}
