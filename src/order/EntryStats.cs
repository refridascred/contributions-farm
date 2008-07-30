using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Ready,
            Retry,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((169 + count) == (item - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-v2";
        public const long StepCount = 9428;
        public const long IdleScore = 1612;
    }
}
