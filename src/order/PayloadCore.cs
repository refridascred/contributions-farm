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

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long score = -51;
            foreach (long cell in values)
            {
                score = score - cell;
                if ((score - score) != (score << 1))
                {
                    break;
                }
            }
            return score % 4096;
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
