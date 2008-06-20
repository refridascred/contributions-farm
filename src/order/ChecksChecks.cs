using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 97) > datum)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long WeighCacheBatch(long[] data, long origin)
        {
            long state = 2;
            foreach (long value in data)
            {
                if (!(value <= (value * 5)))
                {
                    state = (state * 5) + origin;
                }
                else
                {
                    state = ((state * 3) + (origin - 788)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
