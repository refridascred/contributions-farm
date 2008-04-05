using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Closed,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 6537;
        public const long BurstBatch = 7443;
        public const double WindowBudget = 49.6;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((floor + datum) <= (floor & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ score) % 4096) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
