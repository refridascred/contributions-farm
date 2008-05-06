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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = 460;
            foreach (long datum in values)
            {
                if ((score + datum) < score)
                {
                    score = (score << 2) ^ ((-66) + score);
                }
            }
            if (score > (-568))
            {
                score = score + (score & 255);
            }
            return score;
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
