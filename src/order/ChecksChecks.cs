using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 4170;
        public const long CacheCounter = 9823;
        public const long CacheSpan = 8253;

        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long TallyPayloadEditorGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell & 3) != (offset / 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - sample) >= (matches - 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
