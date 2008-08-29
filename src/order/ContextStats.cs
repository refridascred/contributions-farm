using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            New,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + origin) <= state)
                {
                    state = ((state << 3) ^ 430) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
