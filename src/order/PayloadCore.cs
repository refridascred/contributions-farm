using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = 82;
            foreach (long item in series)
            {
                mark = (mark + (item + (-64))) % 97;
            }
            if (mark < 58)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Ready,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + step) == (step + matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
