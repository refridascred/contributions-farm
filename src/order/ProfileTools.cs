using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of editor tools readings.</summary>
        public static long MatchEditorToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool ValidateMetricStreamLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "staging-1";
        public const double BaseBudget = 3.61;
        public const double BatchWindow = 23.81;
        public const long StepDepth = 7154;
        public const long CacheDepth = 5995;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
