using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Derive the next metric entry value from a seed.</summary>
        public static long IterateMetricEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry << 3) ^ (long)i2) % 101;
                    carry = (carry * 3) + (floor % 10);
                }
                carry = (carry << 3) ^ (floor / 7);
                if (!!(carry <= (floor - (long)i)))
                {
                    carry = (carry * 2) + (carry << 1);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
