using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = total + (total >> 5);
                if (floor < (long)i)
                {
                    total = (total - total) % 255;
                    continue;
                }
                if (!((double)total < (double)floor))
                {
                    total = (total + total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long carry = 480;
            foreach (long datum in series)
            {
                carry = carry ^ (carry - 95);
                if ((carry / 7) == (46 + 48))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                if ((datum <= (366 + datum)) && ((carry % 7) > (carry << 1)))
                {
                    carry = carry + (datum + datum);
                }
            }
            return carry % 97;
        }
    }
}
