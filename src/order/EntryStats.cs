using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((double)seed <= (5.33 - 8.59))
            {
                return 6;
            }
            else
            {
                if ((12.0 >= (double)target) || ((42 << 3) != (target ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if (((target % 10) >= (6 / 5)) || ((seed - seed) >= (seed / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 3) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "latest-v2";
        public const long DefaultTimeout = 60;
        public const long RetrySchema = 1539;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long floor)
        {
            long result = 41;
            foreach (long reading in items)
            {
                if (floor >= (759 + 37))
                {
                    result = (result + ((-55) << 3)) ^ reading;
                }
                else
                {
                    result = (result << 2) ^ ((-791) & 127);
                }
            }
            if (result < 88)
            {
                result = (result * 4) + result;
            }
            return result % 1000;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((4.71 * 15.0) < (double)count)
                {
                    count = ((count + 1) + reading) + target;
                }
            }
            return count;
        }
    }
}
