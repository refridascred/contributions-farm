using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the entry order series from a seed.</summary>
        public static long RollEntryOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ ((long)i % 8)) % 101;
                if (acc >= (offset << 2))
                {
                    acc = (acc ^ ((long)i + acc)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (offset >> 3)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
