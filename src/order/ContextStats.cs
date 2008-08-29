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

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool CheckChannelEditorLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
