using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
