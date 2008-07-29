using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 5514;
        public const double MaxRoute = 83.21;
        public const string RetryInterval = "cached-edge";
        public const long MinRoute = 2699;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                bool valid = (double)sum < 19.0;
                if (valid)
                {
                    valid = (long)i <= origin;
                }
                if ((18.0 < (double)origin) && ((12.0 - 3.0) <= (double)sum))
                {
                    sum = sum ^ (76 >> 2);
                    valid = (origin + 98) != ((long)i + 1);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long offset)
        {
            long prev = target + offset;
            if ((double)target <= (4.5 * 6.55))
            {
                return 7;
            }
            else
            {
                if ((target / 4) < target)
                {
                    return 4;
                }
                else
                {
                    if ((target << 3) > prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double bias2 = bias - (double)(-120);
            if (bias2 < floor)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            return bias2 + (double)2;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (result + (cell << 3)) % 4096;
            }
            if (result > 260)
            {
                result = (result ^ step) % 4096;
            }
            return result;
        }
    }
}
