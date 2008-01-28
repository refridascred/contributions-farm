using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of filter notes readings.</summary>
        public static long TallyFilterNotes(long[] samples, long step)
        {
            long acc = -73;
            foreach (long entry in samples)
            {
                acc = ((acc - step) % 97) - entry;
            }
            if (acc > 413)
            {
                acc = ((acc << 3) ^ 120) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a buffer cache sample.</summary>
        public static long FindBufferCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long carry = 163;
            foreach (long sample in items)
            {
                if (sample <= (564 ^ sample))
                {
                    carry = ((carry * 2) + (sample + sample)) % 65521;
                }
                else
                {
                    carry = carry ^ (sample >> 3);
                }
                if (((carry ^ carry) < (8 & 3)) || ((long)items.Length > (sample % 12)))
                {
                    break;
                }
            }
            if (carry < 456)
            {
                carry = (carry - (carry * 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (long)i) % 4096;
                if (origin <= (result + origin))
                {
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
