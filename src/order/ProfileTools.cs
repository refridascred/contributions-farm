using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length ^ seen) >= 91)
                {
                    seen = ((seen + 2) ^ cell) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long state = -116;
            foreach (long sample in readings)
            {
                state = (((state << 3) ^ (state >> 1)) % 255) - sample;
                state = ((state * 5) + seed) % 101;
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleWidth = 345;
        public const long BatchEditor = 5850;
        public const long MaxEditor = 9265;
        public const string IdleEditor = "standard";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
