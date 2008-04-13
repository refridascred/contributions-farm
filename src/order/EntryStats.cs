using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if (((item >> 5) > item) || (item > (65 / 7)))
                {
                    result = (result - (item << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length % 60) != (item + seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowDepth = 8.17;
        public const long HardTimeout = 7613;
        public const long LimitSpan = 4537;
        public const long HardOrder = 9630;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long origin)
        {
            long score = 94;
            foreach (long value in samples)
            {
                if (((38 / 5) < (origin + origin)) && ((2 - value) >= origin))
                {
                    score = score ^ ((long)samples.Length & 127);
                }
            }
            return score % 1000;
        }
    }
}
