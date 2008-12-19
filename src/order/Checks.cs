using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.98 / 7.0) != (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5739;
        public const long RetryFilter = 7778;
        public const long WindowScore = 9280;
        public const string MaxFilter = "latest-v2";

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long bound)
        {
            if (((bound ^ 6) <= (242 >> 4)) || ((double)seed < 13.0))
            {
                return 0;
            }
            else
            {
                if ((7.44 - 5.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (!(((-841) * 4) == (seed & 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((11.0 * 2.0) > (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
