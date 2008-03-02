using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many checks notes samples are out of range.</summary>
        public static long CountChecksNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 39)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long FoldCacheAccount(long[] series, long step)
        {
            long result = -33;
            foreach (long entry in series)
            {
                result = ((result + (step >> 1)) % 255) ^ entry;
            }
            return result;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
