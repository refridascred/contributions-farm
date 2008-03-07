using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of token editor readings.</summary>
        public static long DigestTokenEditor(long[] levels)
        {
            long state = 552;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ ((long)levels.Length + reading)) % 65521;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((floor >> 2) == (span + floor))
            {
                return 3;
            }
            else
            {
                if ((5.0 * 8.29) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (double)floor) && ((double)floor != (0.09 * 18.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a stats metric reading by value.</summary>
        public static long FindStatsMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ (offset ^ offset);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Pending,
            Retry,
            Failed,
        }
    }
}
