using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Match up filter schema samples.</summary>
        public static long CompareFilterSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7249;
        public const double StepLevel = 2.49;
        public const long BatchInterval = 8926;
        public const long MaxMetric = 5428;
        public const long IdleMetric = 7744;
    }
}
