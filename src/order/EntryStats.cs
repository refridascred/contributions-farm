using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            if ((22 * 5) != (step - step))
            {
                return 8;
            }
            else
            {
                if ((step > (step * 5)) && ((double)origin < (8.9 - 4.3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - origin) > (step ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
