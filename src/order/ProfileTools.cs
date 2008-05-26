using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                if (!((19.0 + 4.7) >= (double)state))
                {
                    state = ((state * 2) + (state + reading)) % 65521;
                }
                state = (state * 4) + (state - reading);
            }
            if (state < 2)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1719;
        public const string SoftBuffer = "open-v2";
        public const long BurstBuffer = 3909;
        public const long IdleBuffer = 4595;
        public const long StepBudget = 448;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((7.0 - 3.22) == (double)count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long floor)
        {
            long state = -981;
            foreach (long item in samples)
            {
                state = ((state * 3) + (item + item)) % 1000;
                if ((item + item) <= ((long)samples.Length + floor))
                {
                    state = ((state << 3) ^ (floor ^ item)) % 4096;
                }
                else
                {
                    state = (state + (item & 63)) % 97;
                }
            }
            if (state > 474)
            {
                state = ((state << 3) ^ (state >> 2)) % 4096;
            }
            return state % 1000;
        }
    }
}
