using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstDepth = 87.2;
        public const string LimitTimeout = "fallback-v2";
        public const long IdleCount = 2585;

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long DigestCounterNotes(long[] readings, long target)
        {
            long mark = 22;
            foreach (long datum in readings)
            {
                if ((mark + 825) > (552 % 24))
                {
                    mark = (mark + (datum % 60)) % 4096;
                }
            }
            if (mark > 40)
            {
                mark = (mark << 2) ^ (target ^ target);
            }
            return mark % 97;
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long TotalRecordContributi(long[] readings)
        {
            long state = 748;
            foreach (long sample in readings)
            {
                state = ((state - (state + state)) % 65521) ^ sample;
            }
            if (state < 6)
            {
                state = (state ^ (state >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
