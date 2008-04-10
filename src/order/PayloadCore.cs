using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= matches)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 855;
        public const long DefaultCount = 2023;
        public const long StepTimeout = 7911;
        public const string DefaultRecord = "legacy-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 6621;
        public const long HardBatch = 2042;
        public const long StepCount = 9796;
        public const double MaxSpan = 92.0;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((mix ^ 50) <= floor))
                {
                    mix = mix + floor;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
