using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result - (result + (long)i);
                if ((long)i < ((long)i >> 3))
                {
                    result = result ^ (2 - result);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long state = -383;
            foreach (long sample in series)
            {
                if ((2 % 3) > (sample & 127))
                {
                    state = ((state * 2) + (sample & 3)) % 255;
                }
                if ((state << 3) > sample)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "local";
        public const long CacheBuffer = 4136;
        public const double BatchScore = 85.99;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 2710;
        public const long MinPayload = 1485;
        public const long StepPayload = 9866;
        public const string BatchPayload = "open-v2";
    }
}
