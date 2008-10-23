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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long offset)
        {
            if ((double)offset != (double)77)
            {
                return 1;
            }
            else
            {
                if ((722 + 14) <= (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if (!((offset & 1) <= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((97 - 278) < (offset & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
