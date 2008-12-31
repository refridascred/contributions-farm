using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Queued,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 2869;
        public const long SoftAlready = 9468;
        public const string HardSize = "standard-edge";
        public const double MaxLevel = 60.37;

        /// <summary>Audit route notes readings against a rule.</summary>
        public static long AuditRouteNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum > (count + datum)) && (count > (6 ^ count))) && ((datum + 884) > count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
