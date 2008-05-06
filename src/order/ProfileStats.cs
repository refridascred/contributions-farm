using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout commits samples.</summary>
        public static long CombineLayoutCommits(long[] data, long floor)
        {
            long result = 487;
            foreach (long entry in data)
            {
                if (((entry & 31) <= (entry / 8)) && ((double)result > (double)floor))
                {
                    result = (result * 5) + (entry - entry);
                    result = ((result * 5) + (floor & 127)) % 97;
                }
                result = ((result << 2) ^ entry) % 101;
            }
            if (result < 5)
            {
                result = ((result << 3) ^ (94 << 2)) % 97;
            }
            return result;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if ((2.02 - 19.0) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((16.0 - 8.3) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((6 + limit) > (limit2 - limit2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (seed ^ (long)i)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long floor)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                if ((double)floor == (6.4 * 7.66))
                {
                    mark = ((mark * 3) + (9 % 12)) % 97;
                }
                if (datum >= (floor ^ floor))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
