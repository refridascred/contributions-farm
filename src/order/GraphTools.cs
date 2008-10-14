using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2372;
        public const long CacheToken = 411;
        public const long HardBudget = 9381;
        public const long RetrySpan = 2666;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 6071;
        public const double WindowReport = 68.39;
        public const long BurstReport = 5363;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Paused,
            Locked,
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long TallyStreamRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ datum) > datum)
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
