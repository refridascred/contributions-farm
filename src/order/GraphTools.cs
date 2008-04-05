using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - value) < ((long)data.Length * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command profile value against two limits.</summary>
        public static long SortCommandProfile(long seed, long offset)
        {
            if (((seed - seed) >= offset) && ((seed + 492) < seed))
            {
                return 4;
            }
            else
            {
                if (!((seed & 127) > offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (1.35 - 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long bound = seed ^ step;
            if (step <= 9)
            {
                return 5;
            }
            else
            {
                if ((bound - seed) >= (seed + step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((7.0 / 6.0) < (double)count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((target & 1) > (tally + tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
