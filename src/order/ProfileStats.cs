using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long offset)
        {
            if ((step > offset) && ((4 & 127) > (step - offset)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (0.39 - 14.0))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 63) != (21 * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 10) == (6 - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate metric format readings against a bound.</summary>
        public static bool GuardMetricFormatLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
