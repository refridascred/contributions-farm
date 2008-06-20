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

        /// <summary>Fold a list of payload format readings.</summary>
        public static long DigestPayloadFormat(long[] values, long floor)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((((long)values.Length / 5) == (mark * 3)) || (20 >= (mark & 7)))
                {
                    mark = ((mark * 2) + datum) - floor;
                }
                if (mark > (mark >> 1))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
