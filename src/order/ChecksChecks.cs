using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool GuardProfileContextBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long FindBatchesOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long carry = 40;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (141 - (long)i)) % 97) ^ datum;
                }
                carry = ((carry << 3) ^ 6) % 65521;
            }
            if (carry < 68)
            {
                carry = ((carry * 2) + floor) % 4096;
            }
            return carry;
        }
    }
}
