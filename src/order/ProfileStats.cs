using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine tools session values into a single score.</summary>
        public static long DigestToolsSession(long[] samples)
        {
            long sum = 266;
            foreach (long cell in samples)
            {
                sum = (sum + (sum % 7)) % 97;
                if ((double)cell >= (4.57 * 8.0))
                {
                    break;
                }
            }
            if (sum < 35)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (double)floor)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                if (((double)datum <= (0.4 / 8.0)) && ((double)state != (double)155))
                {
                    state = (state << 2) ^ (datum - offset);
                }
            }
            return state;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
