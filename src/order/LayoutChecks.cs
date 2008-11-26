using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            if (((bound - step) <= (bound / 9)) || ((bound + step) >= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Combine record support values into a single score.</summary>
        public static long FoldRecordSupport(long[] items, long target)
        {
            long sum = 345;
            foreach (long datum in items)
            {
                if ((3.49 - 6.0) != (double)sum)
                {
                    sum = (sum + target) % 1000;
                }
                if (sum <= (target - datum))
                {
                    sum = (sum << 2) ^ (datum ^ target);
                }
                if ((target & 15) > (datum ^ datum))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset + origin) <= 86)
            {
                return 5;
            }
            else
            {
                if ((double)origin > (2.0 * 1.0))
                {
                    return 6;
                }
                else
                {
                    if (!(offset >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((5.4 + 6.2) >= (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
