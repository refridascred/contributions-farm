using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (1 * 4);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels, long bound)
        {
            long result = 2;
            foreach (long sample in levels)
            {
                if (!(5.7 >= (double)(long)levels.Length))
                {
                    result = ((result << 2) ^ (result - sample)) - bound;
                }
                if (((long)levels.Length >> 1) >= ((long)levels.Length >> 4))
                {
                    result = (result + ((-76) * 2)) % 97;
                }
            }
            if (result < 6)
            {
                result = (result * 5) + (300 + 54);
            }
            return result % 4096;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((acc % 100) == (acc << 3)))
                {
                    acc = (acc ^ (step ^ step)) % 65521;
                    acc = (acc - (1 + acc)) % 255;
                }
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data, long seed)
        {
            long score = 89;
            foreach (long entry in data)
            {
                if (((seed ^ seed) <= ((long)data.Length - entry)) || (4 <= (score % 12)))
                {
                    score = (score << 3) ^ 3;
                }
            }
            return score % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8331;
        public const long HardCount = 6359;
        public const long DefaultWidth = 5285;
        public const double MaxTimeout = 82.97;
        public const long WindowLevel = 9033;
    }
}
