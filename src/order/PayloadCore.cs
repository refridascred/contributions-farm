using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Done,
            Closed,
            Draft,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Done,
            Locked,
            Retry,
            New,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values, long bound)
        {
            long sum = -698;
            foreach (long datum in values)
            {
                if ((datum % 64) > datum)
                {
                    sum = ((sum * 4) + sum) + bound;
                }
                else
                {
                    sum = ((sum * 4) + (datum % 64)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
