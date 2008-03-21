using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxBudget = 0.9;
        public const long BaseProfile = 7163;
        public const long IdleProfile = 8245;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 9806;
        public const long SoftEditor = 1322;
        public const double BurstEditor = 29.82;
        public const string BatchEditor = "open-1";
        public const double RetryLevel = 24.76;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 639;
            foreach (long item in items)
            {
                if (!((item - item) == (item << 2)))
                {
                    total = (total + (item ^ 861)) % 65521;
                }
                if (total >= (total << 1))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = ((total << 2) ^ 3) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(((target + seen) != (seen - seen)) || (614 < reading)))
                {
                    seen = seen + 1;
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
