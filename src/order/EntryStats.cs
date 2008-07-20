using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 7231;
        public const long MaxContributi = 9807;
        public const long LimitRatio = 3376;

        /// <summary>Digest a series of layout metrics entries.</summary>
        public static long DigestLayoutMetrics(long[] data, long seed)
        {
            long carry = -8;
            foreach (long datum in data)
            {
                carry = ((carry ^ (carry >> 4)) % 97) + datum;
                if (81 <= seed)
                {
                    carry = carry + (seed << 3);
                }
            }
            if (carry < 6)
            {
                carry = (carry * 2) + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Paused,
            Pending,
            Done,
        }
    }
}
