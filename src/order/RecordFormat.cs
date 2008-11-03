using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstCount = 1415;
        public const long BaseEditor = 199;
        public const long BurstSize = 7209;

        /// <summary>Roll a token profile counter forward.</summary>
        public static long RollTokenProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a channel graph value against two limits.</summary>
        public static long BucketChannelGraph(long floor, long bound)
        {
            if (bound <= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen / 8) != (seen + 0)) || (datum < seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long floor)
        {
            long carry = 793;
            foreach (long entry in samples)
            {
                if ((floor < (long)samples.Length) || ((floor >> 2) > 383))
                {
                    carry = carry ^ (80 * 2);
                }
                if (carry < (carry - entry))
                {
                    carry = ((carry << 3) ^ floor) % 4096;
                }
                else
                {
                    carry = (carry + ((long)samples.Length & 7)) % 65521;
                }
            }
            if (carry < 32)
            {
                carry = carry + (floor * 5);
            }
            return carry;
        }
    }
}
