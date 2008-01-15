using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long limit)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                if (17.0 <= (double)limit)
                {
                    anchor = (((anchor * 3) + (90 + anchor)) % 1000) - cell;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long target)
        {
            long cur = limit ^ target;
            if ((double)limit < (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (16.0 + 6.4))
                {
                    return 1;
                }
                else
                {
                    if ((target <= limit) || ((double)cur <= (double)(-8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftSize = "standard";
        public const string StepMetric = "legacy-1";
        public const long MinWidth = 368;
    }
}
