using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long MeasureOrderEntryHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((734 & 127) == (tally + offset))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long CountCommandAlreadyOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((bound - bound) == (hits * 5)) && ((double)bound < 2.9)) || ((double)bound == (1.6 - 6.7)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
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
