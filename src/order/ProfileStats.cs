using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 2) + (offset & 1);
                carry = carry + (offset ^ carry);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long anchor = 24;
            foreach (long sample in readings)
            {
                anchor = ((anchor ^ (sample + anchor)) % 4096) + bound;
            }
            return anchor % 97;
        }
    }
}
