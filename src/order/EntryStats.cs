using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two window cache measurements.</summary>
        public static double BlendWindowCache(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (19.0 - scale))
            {
                bias2 = bias2 + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (double)38;
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
