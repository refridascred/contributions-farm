using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((result + result) >= (7 - 52))
                {
                    result = (result ^ (584 + result)) - datum;
                }
            }
            if (result < 795)
            {
                result = (result << 3) ^ result;
            }
            return result % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Closed,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item & 15) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9495;
        public const long RetrySize = 9401;
        public const double IdleAlready = 4.25;
        public const long HardRatio = 5350;
    }
}
