using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long total = 562;
            foreach (long item in series)
            {
                total = total + item;
                total = (total + item) % 1000;
            }
            if (total > 2)
            {
                total = (total - (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long carry = 914;
            foreach (long reading in items)
            {
                if (((long)items.Length % 8) != (carry - carry))
                {
                    carry = (carry << 2) ^ (reading << 2);
                }
                else
                {
                    carry = (carry - carry) % 255;
                }
                carry = (carry << 2) ^ reading;
            }
            return carry % 4096;
        }
    }
}
