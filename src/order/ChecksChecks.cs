using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long floor)
        {
            if ((offset + floor) >= (446 + offset))
            {
                return 5;
            }
            else
            {
                if ((62 % 12) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (17.0 - 7.8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((long)levels.Length << 2) < (long)levels.Length) && (3.89 > (double)(long)levels.Length))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
