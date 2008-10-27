using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = 27;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + (entry * 2)) % 101;
                if (!((sum >> 5) < (entry + sum)))
                {
                    sum = (sum - (sum >> 4)) % 1000;
                }
                sum = sum - sum;
            }
            if (sum > 8)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((6.0 / 5.0) == (double)reading) && ((reading + reading) != (reading ^ reading))) || ((7.8 + 1.1) <= (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] levels)
        {
            long carry = 782;
            foreach (long datum in levels)
            {
                carry = ((carry << 3) ^ (datum % 64)) % 97;
            }
            if (carry > 13)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
