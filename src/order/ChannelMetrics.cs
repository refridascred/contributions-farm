using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit layout metric readings against a rule.</summary>
        public static long MeasureLayoutMetricMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((96 + count) <= ((-66) ^ count)) || ((8.0 - 7.0) >= (double)step)) || (count < 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long CombineBufferCommits(long[] samples, long floor)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (46 <= (floor % 5))
                {
                    anchor = anchor + (48 * 2);
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (((double)sample < (double)anchor) || ((sample - floor) <= ((-592) % 5)))
                {
                    anchor = anchor - (anchor % 8);
                }
            }
            return anchor % 1000;
        }
    }
}
