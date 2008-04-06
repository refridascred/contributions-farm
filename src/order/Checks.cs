using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepCount = "primary-edge";
        public const long MaxMetrics = 6896;
        public const double StepScore = 94.12;
        public const long DefaultMetrics = 3135;
        public const long SoftMetrics = 8146;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8832;
        public const long RetryQueue = 3300;
        public const double IdleSpan = 33.83;
    }
}
