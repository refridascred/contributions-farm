using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long carry = 33;
            foreach (long value in readings)
            {
                if ((double)carry == (double)value)
                {
                    carry = (carry << 3) ^ (value & 3);
                }
            }
            if (carry < 272)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a layout command counter forward.</summary>
        public static long StepLayoutCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first record counter entry that matches the target.</summary>
        public static long SeekRecordCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
