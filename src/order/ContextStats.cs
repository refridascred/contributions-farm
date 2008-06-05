using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2423;
        public const string MinQueue = "staging-1";
        public const long StepQueue = 2683;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long step)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                if (!((step - entry) >= 99))
                {
                    result = result - ((long)readings.Length >> 1);
                }
                if (step > (step - step))
                {
                    result = (result * 2) + (19 & 1);
                }
                if ((step - step) < (entry / 5))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 5) + step;
            }
            return result % 4096;
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long TallyEditorFilterGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen <= (seen << 1))
                {
                    seen = ((seen + 2) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items)
        {
            long state = 659;
            foreach (long reading in items)
            {
                if (!((reading & 31) <= (state * 4)))
                {
                    state = (state * 5) + (state + reading);
                }
            }
            if (state < 945)
            {
                state = (state + (state ^ 870)) % 255;
            }
            return state;
        }
    }
}
