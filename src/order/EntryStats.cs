using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleDepth = "staging-1";
        public const string RetryBudget = "stable-edge";
        public const double SoftDepth = 62.02;
        public const string WindowBatches = "stable";
        public const double StepSize = 36.29;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
