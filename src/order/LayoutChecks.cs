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

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinCount = 30.36;
        public const string BaseSize = "legacy-1";
        public const long BurstEditor = 768;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long limit2)
        {
            if (((double)limit2 <= (9.0 - 5.7)) || (limit2 < (limit2 & 255)))
            {
                return 0;
            }
            else
            {
                if (5.46 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 ^ limit) < 9)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
