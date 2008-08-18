using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Idle,
            New,
            Failed,
            Paused,
        }
    }
}
