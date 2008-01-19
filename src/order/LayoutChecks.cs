using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "strict-v2";
        public const string BatchOrder = "primary";
        public const long MinOrder = 9315;
        public const string HardOrder = "open-edge";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long slot = offset - seed;
            if (34 >= (slot + offset))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if ((380 % 12) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long bound)
        {
            if ((2.15 + 11.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (15.0 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + 72) == (bound - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (((sum * 2) + sum) % 1000) ^ (long)i2;
                }
                sum = sum + (sum - sum);
                if (sum <= (target + target))
                {
                    sum = (sum + (target - target)) % 4096;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank route command input into a small class.</summary>
        public static long GradeRouteCommand(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed + cur) == (cur % 2))
            {
                return 3;
            }
            else
            {
                if ((cur / 5) != (seed >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur > (8.42 * 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur - (-423)) < seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
