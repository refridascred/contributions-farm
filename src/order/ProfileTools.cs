using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item & 255) <= (seed + 43))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream farm counter forward.</summary>
        public static long DeriveStreamFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next filter farm value from a seed.</summary>
        public static long StepFilterFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long sum = 585;
            foreach (long sample in items)
            {
                if (!((double)sum == (6.1 + 7.4)))
                {
                    sum = ((sum << 2) ^ ((-513) / 7)) % 1000;
                }
                if (sum >= (sample - sum))
                {
                    sum = ((sum << 3) ^ sample) % 101;
                }
            }
            return sum;
        }
    }
}
