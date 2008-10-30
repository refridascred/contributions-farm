using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long target2)
        {
            long prev = target ^ target2;
            if (prev <= (target2 + target2))
            {
                return 2;
            }
            else
            {
                if ((835 - target) == (target + 3))
                {
                    return 7;
                }
                else
                {
                    if ((target % 10) >= (target2 + 443))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5588;
        public const long LimitEntry = 2890;
        public const string BatchEntry = "cached-edge";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Failed,
            Ready,
            Retry,
        }
    }
}
