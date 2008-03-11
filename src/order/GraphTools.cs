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

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3507;
        public const long HardContext = 6464;
        public const long WindowContext = 2379;
        public const long BurstScore = 9718;

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9167;
        public const string MaxChannel = "legacy-1";
        public const long HardChannel = 1339;
        public const double LimitChannel = 48.58;
    }
}
