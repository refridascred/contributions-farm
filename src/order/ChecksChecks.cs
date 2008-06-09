using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "alpha-v2";
        public const long BaseMetrics = 8126;
        public const long DefaultMetrics = 6774;

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long acc = -11;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (209 + (-4))) ^ (long)i;
                }
                acc = (acc * 5) + (acc / 3);
                if ((acc <= ((long)items.Length >> 1)) || ((item + acc) > (item << 1)))
                {
                    acc = ((acc * 2) + acc) % 97;
                }
                else
                {
                    acc = (acc + (item + item)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            New,
            Draft,
            Done,
            Idle,
        }
    }
}
