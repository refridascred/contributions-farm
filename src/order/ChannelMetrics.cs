using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long offset)
        {
            if (floor >= (floor + offset))
            {
                return 1;
            }
            else
            {
                if (((floor & 255) < (3 - offset)) || (offset > (offset * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 - 11.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > (6.36 - 20.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long GradeTokenSession(long floor, long bound)
        {
            if (((double)bound <= (double)floor) || ((floor + floor) <= (bound >> 4)))
            {
                return 5;
            }
            else
            {
                if (!((double)floor < (5.7 - 1.39)))
                {
                    return 7;
                }
                else
                {
                    if (4.02 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.67 > (double)bound) && ((bound ^ bound) <= (bound - 63)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }
    }
}
