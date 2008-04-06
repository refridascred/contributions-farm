using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - ((-347) + target)) % 97;
                    result = (result + ((long)i2 >> 3)) % 65521;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    result = ((result * 5) + (7 / 6)) - (long)i3;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items)
        {
            long acc = 56;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 4) + (datum / 8)) % 97) ^ (long)i;
                }
                acc = (acc * 2) + acc;
                if ((acc << 3) > acc)
                {
                    acc = (acc ^ 503) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry >= (count ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
