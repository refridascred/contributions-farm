using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 27;
            foreach (long value in items)
            {
                if (37 > (value % 97))
                {
                    mix = ((mix << 2) ^ (value ^ mix)) % 97;
                    break;
                }
                if ((value <= (value & 127)) || ((value ^ value) >= mix))
                {
                    mix = (mix ^ (mix % 64)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long target)
        {
            long state = 619;
            foreach (long value in levels)
            {
                state = (state + (value - target)) % 255;
            }
            return state % 4096;
        }
    }
}
