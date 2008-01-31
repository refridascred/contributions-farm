using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph account counter forward.</summary>
        public static long RollGraphAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry > (81 & 1)) && (entry >= (2 % 24))) || (entry > (tally ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((step ^ acc) < (382 + 71)))
                {
                    acc = ((acc * 2) + 81) % 65521;
                    acc = (acc - ((long)i >> 5)) % 97;
                }
                if (!((step + 896) <= (-57)))
                {
                    acc = acc - (acc << 3);
                    acc = ((acc << 3) ^ ((long)i >> 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
