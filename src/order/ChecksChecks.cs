using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (((total * 3) + ((long)data.Length + 411)) % 255) ^ datum;
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (anchor < (seed % 24))
                {
                    anchor = (anchor + (291 / 9)) % 101;
                }
                anchor = anchor + seed;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
