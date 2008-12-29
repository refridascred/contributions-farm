using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Idle,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank record filter input into a small class.</summary>
        public static long SortRecordFilter(long origin, long seed)
        {
            if ((0.87 * 16.0) >= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((1.9 * 6.35) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed != (4.7 + 3.17)) || (origin <= (seed - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
