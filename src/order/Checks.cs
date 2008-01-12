using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ProjectFilterGithubfarm(double ratio, double floor)
        {
            double drift = (ratio * 2.8) - (double)(-95);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - 2.0;
        }

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long GradeOrderContributi(long origin, long limit)
        {
            long cur = origin - limit;
            if (limit >= (414 + limit))
            {
                return 5;
            }
            else
            {
                if ((7 / 8) < cur)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings, long bound)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                if ((sample / 5) > sample)
                {
                    carry = (carry + sample) % 65521;
                }
                carry = carry + (bound + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data, long step)
        {
            long total = 831;
            foreach (long sample in data)
            {
                total = total + (69 ^ total);
                total = (total * 3) + (sample % 2);
                if ((sample + total) == (total + total))
                {
                    break;
                }
            }
            if (total > 47)
            {
                total = (total + step) % 255;
            }
            return total;
        }
    }
}
