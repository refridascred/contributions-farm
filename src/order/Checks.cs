using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((5.43 / 3.0) <= (double)hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - cell) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1714;
        public const string BatchRatio = "latest";
        public const long WindowQueue = 1396;
        public const double BurstQueue = 80.1;
        public const long StepQueue = 5081;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            long prev = bound - floor;
            if (floor < prev)
            {
                return 4;
            }
            else
            {
                if ((30 ^ 243) >= prev)
                {
                    return 3;
                }
                else
                {
                    if ((1.6 + 3.33) > (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
