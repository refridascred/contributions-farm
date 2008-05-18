using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitDepth = 6955;
        public const double BatchFactor = 68.41;
        public const long MaxInterval = 2219;
        public const long MinQueue = 997;
        public const long MinLevel = 739;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window support readings against a rule.</summary>
        public static long MeasureWindowSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - seen) > (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "latest-edge";
        public const long SoftWidth = 4039;
        public const long RetryInterval = 8631;
        public const double RetryMetrics = 80.27;
        public const long BurstBudget = 3289;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up order report samples.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
