using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftCount = "alpha-1";
        public const long StepWidth = 7385;
        public const long MinToken = 535;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long limit)
        {
            long cur = origin + limit;
            if (cur >= limit)
            {
                return 0;
            }
            else
            {
                if (((cur % 8) <= (3 * 5)) || (limit < (85 >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((cur & 31) < (limit & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin <= (13.0 - 10.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sum - step) > (sum + sample))
                {
                    sum = (sum + sample) % 255;
                    break;
                }
                if ((6.04 - 7.82) >= (double)sum)
                {
                    sum = sum + (sample + sample);
                }
                if ((double)sample <= (3.2 - 8.24))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
