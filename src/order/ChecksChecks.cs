using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long IteratePayloadStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (((2.8 * 3.86) < (double)carry) && ((value + origin) < (value ^ 90)))
                {
                    carry = carry - (value / 2);
                }
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Closed,
        }
    }
}
