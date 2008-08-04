using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            New,
            Idle,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepFactor = 62.07;
        public const long IdleFactor = 2014;
        public const long BaseContributi = 2831;
        public const long HardWidth = 5751;

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long mix = 69;
            foreach (long sample in samples)
            {
                mix = ((mix + (target / 9)) % 65521) - sample;
                if (((double)(long)samples.Length < (2.4 + 5.04)) || ((double)target == (5.88 + 3.0)))
                {
                    mix = mix + (target + mix);
                }
            }
            return mix;
        }
    }
}
