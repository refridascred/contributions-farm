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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitFactor = 4036;
        public const long SoftOrder = 548;
        public const long WindowWidth = 9340;

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
