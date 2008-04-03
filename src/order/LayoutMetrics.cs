using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long bound)
        {
            long sum = 634;
            foreach (long datum in items)
            {
                if (((bound / 2) > (datum + bound)) && (6.57 >= (double)datum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the support format entries that pass the check.</summary>
        public static long AuditSupportFormatHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading <= (count % 8)) && (count < (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
