using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-1";
        public const long BurstInterval = 8088;
        public const long BatchWindow = 1919;
        public const long RetryDepth = 1881;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Done,
            Draft,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long sum = 72;
            foreach (long reading in values)
            {
                if ((sum * 5) < (reading << 2))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
