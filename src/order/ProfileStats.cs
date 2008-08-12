using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen - seen) <= (seen ^ 642)) && (((17.0 * 9.82) <= (double)reading) && ((seen + 10) >= (reading * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long MaxBatch = 4318;
        public const double WindowBatch = 24.34;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Combine counter farm values into a single score.</summary>
        public static long TotalCounterFarm(long[] series)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = (((mix << 2) ^ (mix / 6)) % 4096) + entry;
            }
            return mix;
        }
    }
}
