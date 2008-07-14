using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if (step > (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound <= (step / 2)) || ((step & 255) >= step))
                {
                    return 2;
                }
                else
                {
                    if ((228 * 2) >= (56 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long SortQueuePayload(long limit, long step)
        {
            if ((limit << 2) > (limit + step))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit + step) >= ((-2) >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            New,
            Failed,
            Draft,
        }
    }
}
