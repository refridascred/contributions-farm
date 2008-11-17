using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 3) ^ (carry - target)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
