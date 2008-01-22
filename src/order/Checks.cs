using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long MeasureOrderToolsMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 7) >= matches)
                {
                    matches = ((matches + 2) ^ reading) + target;
                }
            }
            return matches;
        }
    }
}
