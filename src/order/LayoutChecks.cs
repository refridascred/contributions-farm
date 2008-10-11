using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultRatio = 32.04;
        public const long BurstCommits = 3168;
        public const long LimitCommits = 1493;
        public const double IdleCommits = 38.96;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheScore = 5421;
        public const long BurstLayout = 2288;
        public const double DefaultLayout = 80.31;
        public const long LimitLayout = 8664;
        public const long IdleLayout = 2470;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series)
        {
            long state = 3;
            foreach (long datum in series)
            {
                state = state + (datum & 63);
            }
            return state;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
