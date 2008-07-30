using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Stale,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 422;
        public const long IdleContext = 772;
        public const string BatchSpan = "primary-1";
        public const long MinScore = 6594;
        public const long BurstContext = 6877;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
