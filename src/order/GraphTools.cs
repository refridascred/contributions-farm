using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long carry = 365;
            foreach (long datum in levels)
            {
                if (((floor + datum) != (datum & 3)) && (carry <= (datum << 3)))
                {
                    carry = (carry << 3) ^ (datum + floor);
                }
            }
            return carry;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (((origin2 + (-719)) == (origin - origin2)) || ((origin - origin) > (42 + origin)))
            {
                return 3;
            }
            else
            {
                if ((4.16 * 8.4) > (4.68 - 4.0))
                {
                    return 6;
                }
                else
                {
                    if (origin2 <= (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin2 > (3 / 6)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long ClassifyGithubfarmCounter(long target, long offset)
        {
            long slot = target + offset;
            if (((0 / 4) == (target % 10)) && ((6.86 - 14.0) >= (double)slot))
            {
                return 6;
            }
            else
            {
                if ((offset >= (target - offset)) || ((80 ^ offset) >= (target + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((target << 1) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double span)
        {
            double mean = gain;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - 5.0;
        }
    }
}
