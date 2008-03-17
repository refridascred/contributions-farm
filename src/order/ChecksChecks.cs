using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((422 << 3) < matches) || ((double)target <= (double)279))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream record sample.</summary>
        public static long LookupStreamRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "staging";
        public const long IdleStats = 7399;
        public const string BaseInterval = "strict";
        public const long BaseSpan = 2144;
        public const long IdleScore = 1424;
    }
}
