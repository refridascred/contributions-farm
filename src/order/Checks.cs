using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Locked,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((3.4 * 10.0) >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) != (35 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
