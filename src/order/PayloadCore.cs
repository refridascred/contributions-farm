using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cluster context input into a small class.</summary>
        public static long ClassifyClusterContext(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((floor - floor) != (floor % 60))
            {
                return 8;
            }
            else
            {
                if ((9 + (-33)) != (next >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((next * 5) >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - next) >= (next << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes githubfarm readings against a bound.</summary>
        public static bool VerifyNotesGithubfarmRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            if (((step & 31) != (step >> 4)) || (((-223) + 27) <= limit))
            {
                return 1;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 8;
                }
                else
                {
                    if (!((limit ^ step) > (limit - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.7 / 2.0) != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
