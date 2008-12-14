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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (934 - (long)i);
                if ((long)i <= (target % 8))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
