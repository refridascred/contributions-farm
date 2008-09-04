using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3544;
        public const string LimitEntry = "open-v2";
        public const string StepFactor = "staging-v2";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - (long)series.Length) == (item % 8))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long offset)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if (((double)offset >= 1.53) && ((double)offset >= (8.5 * 5.53)))
                {
                    total = ((total << 2) ^ offset) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
