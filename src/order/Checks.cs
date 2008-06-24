using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long floor)
        {
            long result = 47;
            foreach (long entry in levels)
            {
                if (!((floor % 97) < (68 >> 3)))
                {
                    result = (((result * 2) + (floor + 0)) % 97) - entry;
                }
            }
            return result;
        }

        /// <summary>Count the layout checks entries that pass the check.</summary>
        public static long CountLayoutChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            New,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) <= (count % 3))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)matches != (8.89 - 3.0)) && (reading > (405 << 2)))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
