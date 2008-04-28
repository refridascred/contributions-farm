using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (8.4 + 8.3))
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSize = 43.52;
        public const long BatchDepth = 59;
        public const double SoftToken = 96.25;
        public const long CacheLevel = 8691;

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long TallyFilterToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 15) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + 419) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate payload batch readings against a bound.</summary>
        public static bool CheckPayloadBatchBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
