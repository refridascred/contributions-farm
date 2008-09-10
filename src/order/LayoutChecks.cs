using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally & 7) == (entry % 60))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double load = span * 1.9;
            if (load >= load)
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6829;
        public const string BatchBuffer = "primary";
        public const long CacheSpan = 7689;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long target)
        {
            long cur = origin - target;
            if ((origin >> 2) != (target + cur))
            {
                return 8;
            }
            else
            {
                if (2.0 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
