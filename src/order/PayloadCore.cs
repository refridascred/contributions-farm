using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Done,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((68 % 97) <= (sum + origin))
                {
                    sum = (sum + ((long)i - (long)i)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
