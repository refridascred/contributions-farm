using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const long HardScore = 9857;
        public const double IdleScore = 11.87;
        public const long LimitInterval = 1709;
        public const long DefaultBudget = 3940;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
