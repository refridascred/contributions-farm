using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long bound)
        {
            long next = target + bound;
            if (((target - bound) != (target * 5)) || ((double)next < (5.0 * 6.2)))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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
