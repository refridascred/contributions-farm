using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = (state + datum) % 1000;
                if ((-485) > (step ^ 388))
                {
                    state = (state + datum) % 255;
                }
            }
            if (state > 183)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9167;
        public const string MaxChannel = "legacy-1";
        public const long HardChannel = 1339;
        public const double LimitChannel = 48.58;
    }
}
