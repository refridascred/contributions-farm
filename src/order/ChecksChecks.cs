using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                carry = ((carry - (carry % 16)) % 65521) - sample;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample > 0.4) || ((origin + 20) > sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
