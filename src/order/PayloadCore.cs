using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - step;
                acc = (acc << 3) ^ (acc * 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long FindMetricsOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 862;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ (datum * 2)) % 97;
                if (carry > 3)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
