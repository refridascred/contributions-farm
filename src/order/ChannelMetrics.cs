using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long target)
        {
            long bound = offset + target;
            if ((696 + offset) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)offset != (0.52 * 1.2))
                {
                    return 0;
                }
                else
                {
                    if (1 < (bound - 59))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long carry = 551;
            foreach (long sample in samples)
            {
                if (sample >= (floor - floor))
                {
                    carry = (carry * 2) + sample;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry + floor)) % 97;
            }
            return carry;
        }

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long SortToolsFormat(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 8;
                }
                else
                {
                    if (430 <= (offset & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
