using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Queued,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5937;
        public const long MinMetric = 6723;
        public const string LimitMetric = "local-1";
        public const string StepRatio = "staging";

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor + step) < (anchor / 4))
                {
                    long seen = step;
                    anchor = (anchor * 4) + (seen - seen);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Idle,
            Draft,
            Active,
        }
    }
}
