using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 3420;
        public const long StepStats = 4032;
        public const string WindowStats = "local-v2";

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (offset <= (count + count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
