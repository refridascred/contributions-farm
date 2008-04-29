using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 9) < (floor - floor))
                {
                    state = state ^ (floor + floor);
                }
                state = (state * 3) + (floor % 10);
                state = (state * 5) + 58;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Ready,
            Retry,
            New,
            Locked,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((step & 1) < (datum - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
