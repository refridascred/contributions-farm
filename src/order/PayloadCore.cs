using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cluster window entry stays within the limit.</summary>
        public static bool CheckClusterWindowBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - entry) <= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
