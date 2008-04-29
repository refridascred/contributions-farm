using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double load = floor - (12.0 - 9.9);
            if (load > scale)
            {
                load = load - (2.0 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - (scale - floor);
        }

        /// <summary>Check that every payload schema entry stays within the limit.</summary>
        public static bool GuardPayloadSchemaLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 2.45;
        public const long StepSpan = 9993;
        public const long WindowInterval = 4157;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
