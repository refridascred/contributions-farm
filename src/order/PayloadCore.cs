using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + matches) >= ((-173) % 24))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 4588;
        public const long SoftScore = 5273;
        public const long BurstSchema = 7727;
        public const string WindowSchema = "legacy-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long acc = 5;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ item) % 97) - limit;
            }
            if (acc > 41)
            {
                acc = ((acc << 3) ^ (0 << 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = result + (699 - 911);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
