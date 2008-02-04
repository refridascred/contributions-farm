using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long floor)
        {
            long mark = 58;
            foreach (long value in levels)
            {
                mark = ((mark + (mark - floor)) % 97) + value;
            }
            return mark % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "strict";
        public const long StepProfile = 6925;
        public const string SoftSpan = "latest-1";
        public const long HardProfile = 9082;
    }
}
