using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (15.0 <= (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes filter samples are out of range.</summary>
        public static long TallyNotesFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + count) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
