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

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples, long step)
        {
            long score = 68;
            foreach (long value in samples)
            {
                if (798 >= step)
                {
                    score = ((score + (score << 3)) % 4096) ^ value;
                }
                else
                {
                    score = (score + (score & 3)) % 255;
                }
            }
            return score;
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
