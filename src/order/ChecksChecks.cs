using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 887;
            foreach (long cell in levels)
            {
                if (((state / 9) >= (state * 5)) && ((double)state != (0.79 + 11.0)))
                {
                    state = (((state << 2) ^ (state >> 5)) % 255) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i >> 5) >= ((long)i ^ seed)) && ((seed ^ seed) < (7 + anchor)))
                {
                    anchor = anchor ^ (anchor % 12);
                    anchor = ((anchor * 2) + ((long)i - anchor)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
