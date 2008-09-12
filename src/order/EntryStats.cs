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

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long floor)
        {
            if (((floor & 255) > 54) || ((offset / 7) <= (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((offset + (-3)) == (floor * 4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
