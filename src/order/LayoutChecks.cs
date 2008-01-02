using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (double)38)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the route cache series from a seed.</summary>
        public static long RollRouteCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum + step) - (long)i2;
                }
                sum = (sum - (0 ^ step)) % 97;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = ((sum - (long)i) % 97) + (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long seed)
        {
            if ((step >> 3) == (seed - 0))
            {
                return 0;
            }
            else
            {
                if ((seed + 944) < seed)
                {
                    return 2;
                }
                else
                {
                    if (((13.0 / 9.0) <= (7.28 - 13.0)) || ((seed + step) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + step) == (step % 64)) && ((seed % 16) == (89 ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long target)
        {
            long prev = bound - target;
            if (((target + target) > (bound ^ 45)) && ((prev + bound) > (target + prev)))
            {
                return 0;
            }
            else
            {
                if ((9 % 100) <= (bound / 6))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((carry & 127) == (3 % 24))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
