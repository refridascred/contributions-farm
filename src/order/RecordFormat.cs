using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long PairSchemaStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheSize = 11.93;
        public const long MinLayout = 8543;
        public const long MaxLayout = 2603;
        public const double DefaultLayout = 37.19;
        public const long MinDepth = 4831;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long floor)
        {
            long span = seed - floor;
            if (780 <= span)
            {
                return 0;
            }
            else
            {
                if ((seed <= (floor + seed)) && ((double)seed >= (1.0 * 5.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 255) >= floor) && ((seed + seed) < (span + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long ScoreEditorFormat(long[] series, long step)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if (!(sample >= (sample * 4)))
                {
                    result = (result - (688 ^ 268)) % 65521;
                }
            }
            if (result > 85)
            {
                result = (result + (step - 90)) % 4096;
            }
            return result;
        }
    }
}
