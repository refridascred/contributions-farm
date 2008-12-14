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

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double scale = 11.0 + span;
            if (scale < scale)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (scale * 6.77);
            }
            return scale - scale;
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
