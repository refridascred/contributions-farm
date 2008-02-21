using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count < origin) && ((count / 3) != (origin % 7)))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - ((long)i + 394);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum << 3) ^ 346) % 97) ^ (long)i2;
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
