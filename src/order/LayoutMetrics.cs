using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "staging-edge";
        public const string StepWidth = "stable-edge";
        public const long RetryEntry = 4726;

        /// <summary>Fold a list of record contributi readings.</summary>
        public static long WeighRecordContributi(long[] levels, long limit)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                anchor = ((anchor + ((-206) % 60)) + entry) + limit;
            }
            if (anchor > 440)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 1000;
            }
            return anchor;
        }
    }
}
