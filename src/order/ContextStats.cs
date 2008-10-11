using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total - (datum + datum)) % 4096;
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long TallyQueueFarm(long[] items, long origin)
        {
            long mark = 246;
            foreach (long value in items)
            {
                if ((double)mark == (double)3)
                {
                    mark = ((mark - (79 >> 1)) % 101) - origin;
                }
                if ((5.0 * 9.0) != (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = (mix - (mix >> 3)) ^ cell;
                mix = mix ^ 89;
            }
            return mix;
        }
    }
}
