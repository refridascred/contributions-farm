using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            New,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mark = 1;
            foreach (long value in series)
            {
                if (((double)value > 10.0) || (mark < (mark << 2)))
                {
                    mark = (mark + (mark / 9)) % 101;
                }
                else
                {
                    mark = mark + (value & 3);
                }
            }
            if (mark > 89)
            {
                mark = (mark ^ (mark >> 4)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}
