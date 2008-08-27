using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound * 4) >= (24 + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if (((seed - seed) >= (floor - floor)) && ((floor * 3) > (seed - seed)))
            {
                return 4;
            }
            else
            {
                if ((floor < (floor % 3)) && (floor > (floor << 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
