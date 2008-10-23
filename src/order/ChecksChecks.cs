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

        /// <summary>Project the next entry batches value.</summary>
        public static double SmoothEntryBatches(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load - (double)71;
            }
            else
            {
                load = load + (gain + 1.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)40) - (double)(long)i;
            }
            return load + (load + load);
        }
    }
}
