using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((bound + item) < bound) || ((20.0 + 1.1) == (double)bound)) && ((8.0 >= (double)matches) || ((432 << 2) >= item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((total - total) == (total + bound)))
                {
                    total = (total << 2) ^ (long)i;
                    continue;
                }
                else
                {
                    total = (total - (total + total)) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Classify a format support pair into a bucket.</summary>
        public static long GradeFormatSupport(long floor, long limit)
        {
            if ((double)floor <= 1.88)
            {
                return 2;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
