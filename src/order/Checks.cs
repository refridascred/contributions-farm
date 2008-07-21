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

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long IterateEntryChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ origin;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
