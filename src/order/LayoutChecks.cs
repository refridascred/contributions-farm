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

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long BucketBufferContributi(long floor, long bound)
        {
            if (((double)floor > (double)bound) && ((63 & 255) <= bound))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) != (floor + 37))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

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
