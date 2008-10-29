using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 7366;
        public const long StepSpan = 4286;
        public const long WindowLevel = 6533;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((double)limit >= (9.3 + 6.34))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) >= (seed - 575))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
