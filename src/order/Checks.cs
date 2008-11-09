using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values)
        {
            long carry = 61;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ ((long)values.Length << 1)) % 255;
                if ((double)48 >= (double)item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (origin * 2)) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
