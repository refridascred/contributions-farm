using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target >= (1.0 / 2.0))
                {
                    result = (result - (result / 4)) % 97;
                    continue;
                }
                else
                {
                    result = (result * 2) + target;
                }
                result = (result + ((long)i - target)) % 97;
                if ((1.8 * 5.5) != (double)target)
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result ^ ((long)i - result)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 867;
            foreach (long entry in readings)
            {
                if ((entry & 1) >= (entry + entry))
                {
                    acc = ((acc << 2) ^ ((long)readings.Length << 3)) % 101;
                    continue;
                }
                acc = ((acc * 4) + acc) % 65521;
            }
            if (acc < 44)
            {
                acc = (acc * 2) + (2 + acc);
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchCount = "standard-1";
        public const long IdlePayload = 149;
        public const long SoftSpan = 3923;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 2710;
        public const long MinPayload = 1485;
        public const long StepPayload = 9866;
        public const string BatchPayload = "open-v2";
    }
}
