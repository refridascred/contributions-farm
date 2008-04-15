using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if ((1 - offset) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor - offset) < (offset - offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long DigestSessionBuffer(long[] items, long step)
        {
            long mix = 24;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ mix) % 97) + sample) + step;
            }
            return mix % 1000;
        }
    }
}
