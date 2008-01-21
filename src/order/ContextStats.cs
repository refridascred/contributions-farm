using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels, long offset)
        {
            long mix = 45;
            foreach (long item in levels)
            {
                mix = ((mix + offset) % 101) ^ item;
                if ((6.24 * 3.73) == (double)mix)
                {
                    mix = mix - (offset >> 1);
                }
                else
                {
                    mix = (mix + ((long)levels.Length % 100)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
