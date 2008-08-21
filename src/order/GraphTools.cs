using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Combine record context values into a single score.</summary>
        public static long TotalRecordContext(long[] samples)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                mix = ((mix ^ 5) % 255) + reading;
            }
            if (mix < 48)
            {
                mix = mix - (mix + 7);
            }
            return mix;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state >> 3)) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(cell < origin))
                {
                    matches = matches + 1;
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
