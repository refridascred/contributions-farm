using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.2 + 9.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long LookupReportEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Idle,
            Synced,
            Ready,
            Paused,
        }
    }
}
