using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ count) > (count % 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (seed * 2)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long mark = 14;
            foreach (long sample in series)
            {
                if ((72 & 255) >= mark)
                {
                    mark = (mark << 2) ^ (sample + 6);
                }
                if ((double)sample > (3.0 * 6.0))
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            return mark;
        }
    }
}
